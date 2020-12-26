using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Repositories
{
    public interface IUserTaskRepository : IRepository<UserTask>
    {
        Task<IEnumerable<UserTask>> GetUserTasks(string id);
    }
}
