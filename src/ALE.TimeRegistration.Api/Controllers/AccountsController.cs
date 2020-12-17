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

            
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginUserRequestDto login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, isPersistent: false,
           lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                return Unauthorized();
            }
            var user = await _userManager.FindByEmailAsync(login.Email);
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
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(siginingKey),
           SecurityAlgorithms.HmacSha256)
            );
            return token;
        }

    }
}
