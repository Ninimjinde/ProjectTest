using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class MessageSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().HasData(
                new Message {Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" },
                new Message { Id = Guid.Parse(""), TaskId = Guid.Parse(""), ReceiverId = Guid.Parse(""), SenderId = Guid.Parse(""), Text = "" }
                );
        }
    }
}
