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
                new Message { Id = Guid.Parse("00000000-0000-0000-0000-000000000060"), TaskId = Guid.Parse("83ce5bec-f859-4425-bb53-56de4502c2a9"), ReceiverId = Guid.Parse("12ba3def-f041-45dd-bb6c-492749f49d89"), SenderId = Guid.Parse("66d7e6a2-404e-4919-b032-abf64cfe691d"), Text = "Please update your work asap." },
                new Message { Id = Guid.Parse("00000000-0000-0000-0000-000000000061"), TaskId = Guid.Parse("08f00eea-d345-4574-be4e-73f86c56726b"), ReceiverId = Guid.Parse("b92e79e5-bde7-4c85-9d85-cbe405b599a9"), SenderId = Guid.Parse("30a49cd6-9144-40f0-816c-4b1d7a0a766a"), Text = "Can I get more info about the task please?" },
                new Message { Id = Guid.Parse("00000000-0000-0000-0000-000000000062"), TaskId = Guid.Parse("12e02aac-6a7a-49a9-bf18-6e41ecf4075c"), ReceiverId = Guid.Parse("8bc19dd0-6829-49b6-b084-e742cc6403c0"), SenderId = Guid.Parse("e0146a2e-cbec-42cf-8a3c-cfe63b4743e4"), Text = "Please do this asap." },
                new Message { Id = Guid.Parse("00000000-0000-0000-0000-000000000063"), TaskId = Guid.Parse("49745c24-227e-4385-bcba-ed491b62f922"), ReceiverId = Guid.Parse("12ba3def-f041-45dd-bb6c-492749f49d89"), SenderId = Guid.Parse("c3120458-e925-4701-a1c2-f96cd89e8780"), Text = "What should I do when I finish?" }
                );
        }
    }
}
