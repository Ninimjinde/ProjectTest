using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class ProjectSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { Name = "Toyota Motor",  }

                );
        }
    }
}
