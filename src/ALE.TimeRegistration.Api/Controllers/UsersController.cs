using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Interfaces.Services;
using ALE.TimeRegistration.Core.Services;
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
        private readonly IUserService _userService;

        public UsersController(ITaskService taskService, IUserService userService)
        {
            _taskService = taskService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var projects = await _userService.ListAllUsersAsync();
            return Ok(projects);
        }

        [HttpGet("{id}/tasks")]
        public async Task<IActionResult> GetAllTasksUser(Guid userId)
        {
            var userTasks = await _userService.ListAllTasksAsync(userId);
            return Ok(userTasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound($"User with Id {id} does not exist.");
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
            var userResponseDto = await _userService.AddAsync(userRequestDto);
            return CreatedAtAction(nameof(GetUser), new { id = userResponseDto.Id }, userResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> PutUser(UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userResponseDto = await _userService.UpdateAsync(userRequestDto)
           ;
            return Ok(userResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _userService.DeleteAsync(id);
            return Ok();
        }

    }
}
