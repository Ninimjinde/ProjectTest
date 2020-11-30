using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Services
{
    public interface IMobProjectService
    {
        Task<ProjectResponseDto> GetById(Guid id);
        Task<ICollection<ProjectResponseDto>> ListAll();
    }
}
