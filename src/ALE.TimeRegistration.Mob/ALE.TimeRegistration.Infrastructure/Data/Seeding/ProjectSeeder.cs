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
                new Project { Name = "Toyota Motor", Id = Guid.Parse("c9468ac7-468b-4ad2-ad2f-15f42364481a") },
                new Project { Name = "Colruyt", Id = Guid.Parse("e8a33c03-0ecf-41ef-8ec6-88cf7773564e") },
                new Project { Name = "Engie Electrabel", Id = Guid.Parse("557e26b7-e891-476d-9501-b37da557564c") },
                new Project { Name = "Janssen Pharmaceutica", Id = Guid.Parse("dd8f7a03-9e88-4333-8aa2-0e227a718c40") },
                new Project { Name = "Total Belgium", Id = Guid.Parse("aa5448a9-6e7b-4561-9203-af1037428da7") },
                new Project { Name = "BASF Antwerpen", Id = Guid.Parse("8893fc60-83c0-4c1f-ad20-7cd3da784d75") },
                new Project { Name = "Delhaize De Leeuw", Id = Guid.Parse("f8cb37ec-0150-4ee5-ae91-bab50b2c7b55") },
                new Project { Name = "Volvo Car Belgium", Id = Guid.Parse("8aaf9a52-cbc9-41e9-b6d6-56b975b26bb8") },
                new Project { Name = "ArcelorMittal Belgium", Id = Guid.Parse("e641caa7-ab53-42b6-a433-6a1c46ce4f8f") },
                new Project { Name = "Mastercard Europe", Id = Guid.Parse("998ebe9e-c536-4d27-8592-1056a6515fbe") },
                new Project { Name = "Proximus", Id = Guid.Parse("11f97681-bb21-4622-a034-c3ef282dc78e") },
                new Project { Name = "AXA Belgium", Id = Guid.Parse("0b5b0699-2d15-46a5-a60a-9f4dd0f9e8b0") },
                new Project { Name = "Allianz Benelux", Id = Guid.Parse("b89508f1-2935-44b0-aea3-3282850d3814") },
                new Project { Name = "Daikin Europe", Id = Guid.Parse("1ff6ecc8-faa6-4128-bfe2-28a44455fd73") },
                new Project { Name = "bpost", Id = Guid.Parse("62600880-5959-40f1-902c-9d9f8accc795") }
                );
        }
    }
}
