using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using ALE.TimeRegistration.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Infrastructure.Repositories
{
    public class UserTaskRepository : EfRepository<UserTask>, IUserTaskRepository
    {
        public UserTaskRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<UserTask>> GetUserTasks(string userId)
        {
            return await GetAllAsync().Where(ut => (ut.UserId == userId)).ToListAsync();
        }

        public override IQueryable<UserTask> GetAllAsync()
        {
            return _dbContext.UserTasks.AsNoTracking()
                .Include(ut => ut.Task)
                    .ThenInclude(t => t.Project)
                .Include(ut => ut.User);
        }
    }
}
