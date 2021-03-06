﻿using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class ProjectSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { Name = "Toyota Motor", Id = Guid.Parse("00000000-0000-0000-0000-000000000100") },
                new Project { Name = "Colruyt", Id = Guid.Parse("00000000-0000-0000-0000-000000000101") },
                new Project { Name = "Engie Electrabel", Id = Guid.Parse("00000000-0000-0000-0000-000000000102") },
                new Project { Name = "Janssen Pharmaceutica", Id = Guid.Parse("00000000-0000-0000-0000-000000000103") },
                new Project { Name = "Total Belgium", Id = Guid.Parse("00000000-0000-0000-0000-000000000104") },
                new Project { Name = "BASF Antwerpen", Id = Guid.Parse("00000000-0000-0000-0000-000000000105") },
                new Project { Name = "Delhaize De Leeuw", Id = Guid.Parse("00000000-0000-0000-0000-000000000106") },
                new Project { Name = "Volvo Car Belgium", Id = Guid.Parse("00000000-0000-0000-0000-000000000107") },
                new Project { Name = "ArcelorMittal Belgium", Id = Guid.Parse("00000000-0000-0000-0000-000000000108") },
                new Project { Name = "Mastercard Europe", Id = Guid.Parse("00000000-0000-0000-0000-000000000109") },
                new Project { Name = "Proximus", Id = Guid.Parse("00000000-0000-0000-0000-000000000110") },
                new Project { Name = "AXA Belgium", Id = Guid.Parse("00000000-0000-0000-0000-000000000111") },
                new Project { Name = "Allianz Benelux", Id = Guid.Parse("00000000-0000-0000-0000-000000000112") },
                new Project { Name = "Daikin Europe", Id = Guid.Parse("00000000-0000-0000-0000-000000000113") },
                new Project { Name = "bpost", Id = Guid.Parse("00000000-0000-0000-0000-000000000114") }
                );
        }
    }
}
