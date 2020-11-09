using ALE.TimeRegistration.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<TaskResponseDto>> ListAllTasksAsync();
        Task<UserResponsDto> GetByIdAsync(Guid id);
    }
}
