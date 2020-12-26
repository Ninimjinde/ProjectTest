using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ALE.TimeRegistration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountsController(SignInManager<User> signInManager,
                                    UserManager<User> userManager,
                                    IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userManager.Users;
            return Ok(users);
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetUser(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"User with E-mail {email} does not exist.");
            }
            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginUserRequestDto login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, isPersistent: false, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                return Unauthorized();
            }

            var user = await _userManager.FindByEmailAsync(login.Email);
            await _userManager.AddClaimAsync(user, new Claim("email", user.Email));
            JwtSecurityToken token = await GenerateTokenAsync(user);
            //defined
            string serializedToken = new JwtSecurityTokenHandler().WriteToken(token); //serialize the token

            return Ok(new LoginUserResponseDto()
            {
                Token = serializedToken
            });
        }
        private async Task<JwtSecurityToken> GenerateTokenAsync(User user)
        {
            var claims = new List<Claim>();
            // Loading the user Claims
            var userClaims = await _userManager.GetClaimsAsync(user);
            claims.AddRange(userClaims);
            // Loading the roles and put them in a claim of a Role ClaimType
            var roleClaims = await _userManager.GetRolesAsync(user);

            

            foreach (var roleClaim in roleClaims)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleClaim));
            }

            var expirationDays = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationDays");
            var siginingKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigningKey"));
            var token = new JwtSecurityToken
            (
                issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                audience: _configuration.GetValue<string>("JWTConfiguration:Audience"),
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(siginingKey), SecurityAlgorithms.HmacSha256)
            );

            return token;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            User newUser = new User
            {
                Email = userRequestDto.Email,
                Name = userRequestDto.Name,
                LastName = userRequestDto.LastName,
                UserName = userRequestDto.Email
            };

            IdentityResult result = await _userManager.CreateAsync(newUser, userRequestDto.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            newUser = await _userManager.FindByEmailAsync(userRequestDto.Email);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutUser(LoginUserRequestDto loginUserRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _userManager.FindByEmailAsync(loginUserRequestDto.Email);
            var userResponseDto = await _userManager.UpdateAsync(user)
           ;
            return Ok(userResponseDto);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserRequestDto deleteUserRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _userManager.FindByEmailAsync(deleteUserRequestDto.Email);
            await _userManager.DeleteAsync(user);
            return Ok();
        }

    }
}
