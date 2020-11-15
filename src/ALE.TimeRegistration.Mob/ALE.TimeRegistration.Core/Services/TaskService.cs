using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using ALE.TimeRegistration.Core.Interfaces.Services;
using ALE.TimeRegistration.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Task = ALE.TimeRegistration.Core.Entities.Task;
using Microsoft.EntityFrameworkCore;

namespace ALE.TimeRegistration.Core.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Task> _taskRepo;
        public TaskService(IMapper mapper, IRepository<Task> taskRepo)
        {
            _mapper = mapper;
            _taskRepo = taskRepo;
        }
        public async Task<TaskResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _taskRepo.GetAllAsync()
                .Include(t => t.TaskUsers)
                    .ThenInclude(tu => tu.User)
                .Include(t => t.Project)
                .Include(t => t.Pictures)
                .SingleOrDefaultAsync(t => t.Id.Equals(id));
            var dto = _mapper.Map<TaskResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<TaskResponseDto>> ListAllTasksAsync()
        {
            var result = await _taskRepo.GetAllAsync()
                .Include(t => t.TaskUsers)
                    .ThenInclude(tu => tu.User)
                .Include(t => t.Project)
                .Include(t => t.Pictures)
                .ToListAsync();
            var dto = _mapper.Map<IEnumerable<TaskResponseDto>>(result);
            return dto;
        }

        public async Task<TaskResponseDto> AddAsync(TaskRequestDto taskRequestDto)
        {
            var task = _mapper.Map<Task>(taskRequestDto);
            var result = await _taskRepo.AddAsync(task);
            var dto = _mapper.Map<TaskResponseDto>(result);
            return dto;

        }
    }
}
