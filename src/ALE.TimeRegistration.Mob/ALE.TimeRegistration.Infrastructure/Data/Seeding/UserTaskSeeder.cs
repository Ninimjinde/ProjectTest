using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class UserTaskSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTask>().HasData(
                new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000200"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000006") }
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000201"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000006") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000202"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000203"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000204"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000205"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000009") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000206"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000010") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000207"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000208"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000209"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000210"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000015") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000211"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000016") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000212"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000017") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000213"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000020") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000214"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000020") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000215"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000021") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000216"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000021") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000217"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000021") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000218"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000022") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000219"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000023") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000220"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000024") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000221"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000024") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000223"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000025") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000224"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000017") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000225"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000025") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000226"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000026") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000227"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000027") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000228"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000028") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000229"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000029") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000230"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000030") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000231"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000015") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000232"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000030") },
                //new UserTask { TaskId = Guid.Parse("00000000-0000-0000-0000-000000000233"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000030") }
                );
        }
    }
}
