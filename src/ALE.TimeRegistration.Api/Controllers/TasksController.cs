using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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

        [HttpGet("/user/{id}")]
        public async Task<IActionResult> GetUserTasks(Guid id)
        {
            var task = await _taskService.GetUserTasks(id);
            if (task == null)
            {
                return NotFound($"Task with Id {id} does not exist.");
            }

            return Ok(task);
        }

        [HttpPost]
        public async Task<IActionResult> PostTask(AppTaskRequestDto taskRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var taskResponseDto = await _taskService.AddAsync(taskRequestDto);
            return CreatedAtAction(nameof(GetTask), new { id = taskResponseDto.Id }, taskResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> PutTask(AppTaskRequestDto taskRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var taskResponseDto = await _taskService.UpdateAsync(taskRequestDto)
           ;
            return Ok(taskResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _taskService.DeleteAsync(id);
            return Ok();
        }

    }
}
