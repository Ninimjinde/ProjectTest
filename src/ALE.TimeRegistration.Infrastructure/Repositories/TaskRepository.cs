using ALE.TimeRegistration.Core.Interfaces.Repositories;
using ALE.TimeRegistration.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Infrastructure.Repositories
{
    public class TaskRepository : EfRepository<Core.Entities.AppTask>, ITaskRepository
    {
        public TaskRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<Core.Entities.AppTask> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(a => a.Id.Equals(id));
        }
        public override IQueryable<Core.Entities.AppTask> GetAllAsync()
        {
            return _dbContext.Tasks.AsNoTracking()
                .Include(t => t.TaskUsers)
                    .ThenInclude(tu => tu.User)
                .Include(t => t.Project)
                .Include(t => t.Pictures);
        }
    }
}
