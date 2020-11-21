using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Services
{
    public interface ITaskService
    {
        Task<AppTask> GetById(Guid id);

        Task<IQueryable<AppTask>> ListAllTasks();

    }
}
