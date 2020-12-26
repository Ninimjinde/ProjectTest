using ALE.TimeRegistration.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Services
{
    public interface IUserTaskService
    {
        Task<UserTaskResponseDto> AddAsync(UserTaskRequestDto taskRequestDto);
        Task<IEnumerable<UserTaskResponseDto>> GetUserTasks(Guid id);
        Task<IEnumerable<UserTaskResponseDto>> ListAllTasksAsync();
    }
}
