using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<List<Project>> GetProjectsByUserAsync(Guid userId);
    }
}
