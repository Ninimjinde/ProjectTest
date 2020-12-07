using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Services
{
    public interface IMobTaskService
    {
        Task<AppTaskResponseDto> GetById(Guid id);

        Task<ICollection<AppTaskResponseDto>> ListAllTasksFromProject(ProjectResponseDto project);

    }
}
