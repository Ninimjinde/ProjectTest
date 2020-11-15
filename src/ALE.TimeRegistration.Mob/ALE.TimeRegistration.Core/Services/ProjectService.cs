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
        private readonly IRepository<Project> _projectRepo;
        public ProjectService(IMapper mapper, IRepository<Project> projectRepo)
        {
            _mapper = mapper;
            _projectRepo = projectRepo;
        }
        public async Task<ProjectResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _projectRepo.GetAllAsync()
                 .Include(p => p.Tasks)
                 .SingleOrDefaultAsync(p => p.Id.Equals(id));
            var dto = _mapper.Map<ProjectResponseDto>(result);
            return dto;

        }

        public async Task<IEnumerable<ProjectResponseDto>> ListAllAsync()
        {
            var result = await _projectRepo.GetAllAsync()
                .Include(p => p.Tasks)
                .ToListAsync();
            var dto = _mapper.Map<IEnumerable<ProjectResponseDto>>(result);
            return dto;
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

        public async System.Threading.Tasks.Task DeleteAsync(Guid id)
        {
            await _projectRepo.DeleteAsync(id);

        }
    }
}
