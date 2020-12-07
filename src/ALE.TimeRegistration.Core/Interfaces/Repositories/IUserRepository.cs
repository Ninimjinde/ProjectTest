using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> ListAllTasksAsync(Guid userId);
    }
}
