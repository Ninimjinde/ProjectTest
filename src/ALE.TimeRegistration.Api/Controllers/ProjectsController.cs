using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALE.TimeRegistration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
        {
            var projects = await _projectService.ListAllAsync();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(Guid id)
        {
            var project = await _projectService.GetByIdAsync(id);
            if (project == null)
            {
                return NotFound($"Project with Id {id} does not exist.");
            }

            return Ok(project);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetProjectsByUser(Guid id)
        {
            var project = await _projectService.GetProjectsByUserAsync(id);
            if (project == null)
            {
                return NotFound($"User doesn't have any projects.");
            }

            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> PostProject(ProjectRequestDto projectRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var projectResponseDto = await _projectService.AddAsync(projectRequestDto);
            return CreatedAtAction(nameof(GetProject), new { id = projectResponseDto.Id }, projectResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> PutProject(ProjectRequestDto projectRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var projectResponseDto = await _projectService.UpdateAsync(projectRequestDto)
           ;
            return Ok(projectResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _projectService.DeleteAsync(id);
            return Ok();
        }

    }
}
