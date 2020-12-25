using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Repositories
{
    public interface ITaskRepository : IRepository<AppTask>
    {
        Task<List<AppTask>> GetUserTasks(Guid userId);
    }
}
