using ALE.TimeRegistration.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectResponseDto>> ListAllAsync();
        Task<ProjectResponseDto> GetByIdAsync(Guid id);
        Task<List<ProjectResponseDto>> GetProjectsByUserAsync(Guid id);
        Task<ProjectResponseDto> AddAsync(ProjectRequestDto projectRequestDto);
        Task<ProjectResponseDto> UpdateAsync(ProjectRequestDto projectRequestDto);
        Task DeleteAsync(Guid id);

    }
}
