using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<UserTask> UserProjects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<UserTask>()
                .ToTable("UserProject")
                .HasKey(up => new { up.UserId, up.ProjectId });
            modelBuilder.Entity<UserTask>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserProjects)
                .HasForeignKey(u => u.UserId);
            modelBuilder.Entity<UserTask>()
                .HasOne(up => up.Project)
                .WithMany(p => p.ProjectUsers)
                .HasForeignKey(p => p.ProjectId);
        }
    }
}
