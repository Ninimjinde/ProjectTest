using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Core.Interfaces.Services;
using ALE.TimeRegistration.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ITaskService _taskService;
        //private readonly IUserService _userService;
        private readonly UserManager<UserRequestDto> _userManager;

        public UsersController(ITaskService taskService, UserManager<UserRequestDto> userManager)
        {
            _taskService = taskService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userManager.Users;
            return Ok(users);
        }

/*        [HttpGet("{id}/tasks")]
        public async Task<IActionResult> GetAllTasksUser(Guid userId)
        {
            var userTasks = await _userService.ListAllTasksAsync(userId);
            return Ok(userTasks);
        }*/

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

        [HttpPost]
        public async Task<IActionResult> PostUser(UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userResponseDto = await _userManager.CreateAsync(userRequestDto);
            return Ok(userResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> PutUser(UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userResponseDto = await _userManager.UpdateAsync(userRequestDto)
           ;
            return Ok(userResponseDto);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _userManager.DeleteAsync(userRequestDto);
            return Ok();
        }

    }
}
