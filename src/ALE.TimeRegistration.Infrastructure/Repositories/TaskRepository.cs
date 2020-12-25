using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using ALE.TimeRegistration.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Infrastructure.Repositories
{
    public class TaskRepository : EfRepository<AppTask>, ITaskRepository
    {
        public TaskRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<AppTask> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(a => a.Id.Equals(id));
        }
        public override IQueryable<AppTask> GetAllAsync()
        {
            return _dbContext.Tasks.AsNoTracking()
                .Include(t => t.TaskUsers)
                    .ThenInclude(tu => tu.User)
                .Include(t => t.Project)
                .Include(t => t.Pictures);
        }

        public Task<List<AppTask>> GetUserTasks(Guid userId)
        {
            return _dbContext.UserTasks.Where(ut => ut.UserId.Equals(userId)).Select(ut => ut.Task).ToListAsync();
        }
    }
}
