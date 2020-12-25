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
    public class ProjectRepository : EfRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<Project> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(a => a.Id.Equals(id));
        }
        public override IQueryable<Project> GetAllAsync()
        {
            return _dbContext.Projects.AsNoTracking()
                .Include(p => p.Tasks);
        }


        public async Task<List<Project>> GetProjectsByUserAsync(Guid userId)
        {
            return await _dbContext.UserTasks.Where(ut => ut.UserId.Equals(userId)).Select(ut => ut.Task).Select(t => t.Project).ToListAsync();
        }
    }
}
