using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class PictureSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Picture>().HasData(
                new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000300"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000200") }
                //new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000301"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000201") },
                //new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000302"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000201") },
                //new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000303"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000202") },
                //new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000304"), TaskId = Guid.Parse("00000000-0000-0000-0000-000000000203") }
                );
        }
    }
}
