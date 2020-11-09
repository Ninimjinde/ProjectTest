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
                new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000050"), TaskId = Guid.Parse("84985336-8b0f-4fcc-883f-affa41175ef2") },
                new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000051"), TaskId = Guid.Parse("84985336-8b0f-4fcc-883f-affa41175ef2") },
                new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000052"), TaskId = Guid.Parse("1fd57179-6a38-43ee-ace3-edbce12f7bb0") },
                new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000053"), TaskId = Guid.Parse("1fd57179-6a38-43ee-ace3-edbce12f7bb0") },
                new Picture { Id = Guid.Parse("00000000-0000-0000-0000-000000000054"), TaskId = Guid.Parse("97ea799b-2366-4896-b334-cde128c11934") }
                );
        }
    }
}
