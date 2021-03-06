﻿using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ALE.TimeRegistration.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        //public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<AppTask> Tasks { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
    
            modelBuilder.Entity<UserTask>()
                .ToTable("UserTasks")
                 .HasOne(ut => ut.User)
                 .WithMany(u => u.UserTasks)
                 .HasForeignKey(ut => ut.UserId);
            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.Task)
                .WithMany(t => t.TaskUsers)
                .HasForeignKey(ut => ut.TaskId);

            modelBuilder.Entity<Message>()
                .ToTable("Messages")
                .HasKey(m => m.Id);
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SendMessages)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(m => m.SenderId);
            modelBuilder.Entity<Message>()
                 .HasOne(m => m.Receiver)
                 .WithMany(u => u.ReceivedMessages)
                 .OnDelete(DeleteBehavior.NoAction)
                 .HasForeignKey(m => m.ReceiverId);
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Task)
                .WithMany(t => t.Messages)
                .HasForeignKey(m => m.TaskId);

            modelBuilder.Entity<Picture>()
                .ToTable("Pictures")
                .Ignore(p => p.Image);
            modelBuilder.Entity<Picture>()
                .HasOne(p => p.Task)
                .WithMany(t => t.Pictures)
                .HasForeignKey(p => p.TaskId);

            modelBuilder.Entity<AppTask>()
                .ToTable("Tasks")
                .HasOne(t => t.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectId);


            UserSeeder.Seed(modelBuilder);
            IdentityRoleSeeder.Seed(modelBuilder);
            IdentityUserRoleSeeder.Seed(modelBuilder);
            ProjectSeeder.Seed(modelBuilder);
            TaskSeeder.Seed(modelBuilder);
            UserTaskSeeder.Seed(modelBuilder);
            MessageSeeder.Seed(modelBuilder);
            PictureSeeder.Seed(modelBuilder);
      
        }
    }
}
