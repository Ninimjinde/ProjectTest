using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using ALE.TimeRegistration.Core.Interfaces.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepo;
        public ProjectService(IMapper mapper, IProjectRepository projectRepo)
        {
            _mapper = mapper;
            _projectRepo = projectRepo;
        }
        public async Task<ProjectResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _projectRepo.GetByIdAsync(id);
            var dto = _mapper.Map<ProjectResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<ProjectResponseDto>> ListAllAsync()
        {
            var result = await _projectRepo.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<ProjectResponseDto>>(result);
            return dto;
        }
        public async Task<List<ProjectResponseDto>> GetProjectsByUserAsync(Guid id)
        {
            var result = await _projectRepo.GetProjectsByUserAsync(id);
            var dto = _mapper.Map<IEnumerable<ProjectResponseDto>>(result);
            return (List<ProjectResponseDto>)dto;
        }

        public async Task<ProjectResponseDto> AddAsync(ProjectRequestDto projectRequestDto)
        {
            var project = _mapper.Map<Project>(projectRequestDto);
            var result = await _projectRepo.AddAsync(project);
            var dto = _mapper.Map<ProjectResponseDto>(result);
            return dto;
        }

        public async Task<ProjectResponseDto> UpdateAsync(ProjectRequestDto projectRequestDto)
        {
            var project = _mapper.Map<Project>(projectRequestDto);
            var result = await _projectRepo.UpdateAsync(project);
            var dto = _mapper.Map<ProjectResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _projectRepo.DeleteAsync(id);

        }

    }
}
