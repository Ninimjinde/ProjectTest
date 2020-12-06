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
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<User> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(a => a.Id.Equals(id));
        }
        public override IQueryable<User> GetAllAsync()
        {
            return _dbContext.Users.AsNoTracking()
                .Include(u => u.UserTasks)
                    .ThenInclude(ut => ut.Task)
                .Include(u => u.ReceivedMessages)
                .Include(u => u.SendMessages);
        }
        public async Task<IEnumerable<User>> ListAllTasksAsync(Guid userId)
        {
            return await GetAllAsync()
                .Where(u => u.Id.Equals(userId))
                .Include(u => u.UserTasks)
                    .ThenInclude(ut => ut.Task)
                .ToListAsync();
        }
    }
}
