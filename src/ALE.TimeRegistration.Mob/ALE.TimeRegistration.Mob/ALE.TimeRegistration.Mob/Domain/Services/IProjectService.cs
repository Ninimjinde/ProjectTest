using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Services
{
    public interface IProjectService
    {
        Task<Project> GetById(Guid id);
        Task<IQueryable<Project>> ListAll();
    }
}
