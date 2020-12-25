using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class MessageSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().HasData(
                new Message { Id = Guid.Parse("00000000-0000-0000-0000-000000000400"), SenderId = "00000000-0000-0000-0000-000000000001", ReceiverId = "00000000-0000-0000-0000-000000000006", TaskId = Guid.Parse("00000000-0000-0000-0000-000000000200"), Text = "Please update your work asap." },
                new Message { ReceiverId = "00000000-0000-0000-0000-000000000001", SenderId = "00000000-0000-0000-0000-000000000006", Id = Guid.Parse("00000000-0000-0000-0000-000000000401"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000201"), Text = "Can I get more info about the task please?" },
                new Message { ReceiverId = "00000000-0000-0000-0000-000000000007", SenderId = "00000000-0000-0000-0000-000000000001", Id = Guid.Parse("00000000-0000-0000-0000-000000000402"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000202"), Text = "Please do this asap." },
                new Message { ReceiverId = "00000000-0000-0000-0000-000000000001", SenderId = "00000000-0000-0000-0000-000000000006", Id = Guid.Parse("00000000-0000-0000-0000-000000000403"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000200"), Text = "What should I do when I finish?" }
                );
        }
    }
}
