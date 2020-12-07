using ALE.TimeRegistration.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskResponseDto>> ListAllTasksAsync();
        Task<TaskResponseDto> GetByIdAsync(Guid id);
        Task<TaskResponseDto> AddAsync(TaskRequestDto taskRequestDto);
        Task<TaskResponseDto> UpdateAsync(TaskRequestDto taskRequestDto);
        Task DeleteAsync(Guid id);

    }
}
