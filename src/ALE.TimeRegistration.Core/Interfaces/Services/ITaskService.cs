using ALE.TimeRegistration.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<AppTaskResponseDto>> ListAllTasksAsync();
        Task<AppTaskResponseDto> GetByIdAsync(Guid id);
        Task<AppTaskResponseDto> AddAsync(AppTaskRequestDto taskRequestDto);
        Task<AppTaskResponseDto> UpdateAsync(AppTaskRequestDto taskRequestDto);
        Task DeleteAsync(Guid id);

    }
}
