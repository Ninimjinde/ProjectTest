using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Services
{
    public interface IMobProjectService
    {
        Task<ProjectResponseDto> GetById(Guid id);
        Task<ICollection<ProjectResponseDto>> ListAll();
    }
}
