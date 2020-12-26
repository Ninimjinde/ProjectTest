using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALE.TimeRegistration.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ALE.TimeRegistration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTasksController : Controller
    {
        private readonly IUserTaskService _userTaskService;
        public UserTasksController(IUserTaskService userTaskService)
        {
            _userTaskService = userTaskService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllTasksAsync()
        {
            var usertasks = await _userTaskService.ListAllTasksAsync();

            if (usertasks == null)
            {
                return NotFound($"There are no tasks with users.");
            }

            return Ok(usertasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserTasks(Guid id)
        {
            var usertasks = await _userTaskService.GetUserTasks(id);

            if (usertasks == null)
            {
                return NotFound($"User with Id {id} does not have tasks.");
            }

            return Ok(usertasks);
        }
    }
}
