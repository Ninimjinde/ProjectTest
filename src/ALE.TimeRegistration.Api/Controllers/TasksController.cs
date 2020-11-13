using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALE.TimeRegistration.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALE.TimeRegistration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {
            var tasks = await _taskService.ListAllTasksAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTask(Guid id)
        {
            var task = await _taskService.GetByIdAsync(id);
            if (task == null)
            {
                return NotFound($"Task with Id {id} does not exist.");
            }

            return Ok(task);
        }
    }
}
