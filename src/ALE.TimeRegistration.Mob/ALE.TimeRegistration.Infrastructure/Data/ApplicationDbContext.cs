﻿using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Infrastructure.Data.Seeding;
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
                .HasKey(ut => new { ut.UserId, ut.TaskId });
            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.User)
                .WithMany(u => u.UserTasks)
                .HasForeignKey(u => u.UserId);
            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.Task)
                .WithMany(t => t.TaskUsers)
                .HasForeignKey(t => t.TaskId);

            modelBuilder.Entity<Message>()
                .HasKey(m => new { m.SenderId, m.ReceiverId });
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.SenderId);
            //modelBuilder.Entity<Message>()
            //    .HasOne(m => m.Receiver)
            //    .WithMany(u => u.Messages)
            //    .HasForeignKey(m => m.ReceiverId);

            modelBuilder.Entity<User>()
                .Ignore(u => u.DateOfBirth);

            UserSeeder.Seed(modelBuilder);
            ProjectSeeder.Seed(modelBuilder);
            TaskSeeder.Seed(modelBuilder);
            MessageSeeder.Seed(modelBuilder);
            PictureSeeder.Seed(modelBuilder);
            UserTaskSeeder.Seed(modelBuilder);
        }
    }
}
