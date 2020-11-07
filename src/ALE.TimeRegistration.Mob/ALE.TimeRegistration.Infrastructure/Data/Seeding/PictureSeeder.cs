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
                new Picture { Id = Guid.Parse("856b1fd5-44f6-4dd5-96b8-4e6c72b1c0df"), TaskId = Guid.Parse("84985336-8b0f-4fcc-883f-affa41175ef2")},
                new Picture { Id = Guid.Parse("981bb07b-ffb9-4901-ab4d-bf84fa279297"), TaskId = Guid.Parse("84985336-8b0f-4fcc-883f-affa41175ef2")},
                new Picture { Id = Guid.Parse("a6a8c0ef-66ae-4b0a-8dcf-c323db0bab32"), TaskId = Guid.Parse("bdf71f7a-24e4-4332-8f56-650b089fa1f0")},
                new Picture { Id = Guid.Parse("bb7413e9-f087-4550-bc5b-9594f79281c8"), TaskId = Guid.Parse("b5edeb11-3a16-4f1e-8820-94aeb21ba0d7")},
                new Picture { Id = Guid.Parse("70da31cc-8b9e-44fe-9722-c03aa91dee9f"), TaskId = Guid.Parse("3e3a9323-2f38-4e69-80fe-053f5d2f8c35")}
                );
        }
    }
}
