using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using ALE.TimeRegistration.Core.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppTask = ALE.TimeRegistration.Core.Entities.AppTask;

namespace ALE.TimeRegistration.Core.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMapper _mapper;
        private readonly ITaskRepository _taskRepo;
        public TaskService(IMapper mapper, ITaskRepository taskRepo)
        {
            _mapper = mapper;
            _taskRepo = taskRepo;
        }
        public async Task<AppTaskResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _taskRepo.GetByIdAsync(id);
            var dto = _mapper.Map<AppTaskResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<AppTaskResponseDto>> ListAllTasksAsync()
        {
            var result = await _taskRepo.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<AppTaskResponseDto>>(result);
            return dto;
        }

        public async Task<AppTaskResponseDto> AddAsync(AppTaskRequestDto taskRequestDto)
        {
            var task = _mapper.Map<AppTask>(taskRequestDto);
            task.UploadDate = DateTime.UtcNow;
            var result = await _taskRepo.AddAsync(task);
            var dto = _mapper.Map<AppTaskResponseDto>(result);
            return dto;

        }

        public async Task<AppTaskResponseDto> UpdateAsync(AppTaskRequestDto taskRequestDto)
        {
            var task = _mapper.Map<AppTask>(taskRequestDto);
            var result = await _taskRepo.UpdateAsync(task);
            var dto = _mapper.Map<AppTaskResponseDto>(result);
            return dto;
        }

        public async System.Threading.Tasks.Task DeleteAsync(Guid id)
        {
            await _taskRepo.DeleteAsync(id);

        }
    }
}
