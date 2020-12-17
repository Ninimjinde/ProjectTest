using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ALE.TimeRegistration.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
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
            modelBuilder.Entity<UserTask>()
                .ToTable("UserTasks")
                .HasKey(ut => new { ut.UserId, ut.TaskId });
            modelBuilder.Entity<UserTask>()
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
            ProjectSeeder.Seed(modelBuilder);
            TaskSeeder.Seed(modelBuilder);
            UserTaskSeeder.Seed(modelBuilder);
            MessageSeeder.Seed(modelBuilder);
            PictureSeeder.Seed(modelBuilder);

            const string AdminRoleId = "00000000-0000-0000-0000-000000000001";
            const string AdminRoleName = "Admin";
            const string AdminUserId = "00000000-0000-0000-0000-000000000001";
            const string AdminUserName = "aboynamedsue@JCash.com";
            const string AdminUserPassword = "TimeReg2020"; // For demo purposes only! Don't do this in real application!

            IPasswordHasher<User> passwordHasher = new PasswordHasher<User>(); // Identity password hasher

            User adminApplicationUser = new User
            {
                Id = AdminUserId,
                UserName = AdminUserName,
                NormalizedUserName = AdminUserName.ToUpper(),
                Email = AdminUserName,
                NormalizedEmail = AdminUserName.ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", //Random string
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58" //Random guid string
                
            };

            adminApplicationUser.PasswordHash = passwordHasher.HashPassword(adminApplicationUser, AdminUserPassword);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = AdminRoleId,
                Name = AdminRoleName,
                NormalizedName = AdminRoleName.ToUpper()
            });

            modelBuilder.Entity<User>().HasData(adminApplicationUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = AdminRoleId,
                UserId = AdminUserId
            });

        }
    }
}
