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
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("")},
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") },
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") },
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") },
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") },
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") },
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") },
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") },
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") },
                new Picture { Id = Guid.Parse(""), TaskId = Guid.Parse(""), Image = new Uri("") }
                );
        }
    }
}
