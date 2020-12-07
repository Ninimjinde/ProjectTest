using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class UserTaskSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTask>().HasData(
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000006"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000200") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000006"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000201") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000007"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000202") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000008"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000203") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000008"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000204") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000009"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000205") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000010"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000206") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000207") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000208") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000209") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000015"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000210") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000016"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000211") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000017"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000212") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000020"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000213") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000020"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000214") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000021"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000215") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000021"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000216") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000021"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000217") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000022"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000218") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000023"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000219") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000024"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000220") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000024"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000221") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000025"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000223") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000017"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000224") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000025"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000225") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000026"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000226") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000027"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000227") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000028"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000228") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000029"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000229") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000030"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000230") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000015"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000231") },
                new UserTask { UserId = Guid.Parse("00000000-0000-0000-0000-000000000030"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000232") }
                );
        }
    }
}
