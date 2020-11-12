using ALE.TimeRegistration.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectResponseDto>> ListAllTasksAsync();
        Task<ProjectResponseDto> GetByIdAsync(Guid id);
    }
}
