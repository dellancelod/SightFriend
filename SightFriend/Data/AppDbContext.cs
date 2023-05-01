using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SightFriend.Models;

namespace SightFriend.Data
{
    public partial class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "0",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "1",
                Name = "user",
                NormalizedName = "USER"
            });
            
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "b167495c-7b90-4b05-8dc8-256823348341",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                PhoneNumber = "555",
                PhoneNumberConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> {
                RoleId = "0",
                UserId = "b167495c-7b90-4b05-8dc8-256823348341"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "b9dacebc-402e-48df-8d60-dae005eece05",
                UserName = "Даніл Світайло",
                NormalizedUserName = "ДАНІЛ СВІТАЙЛО",
                PhoneNumber = "0955880395",
                PhoneNumberConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "danilsv"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "b9dacebc-402e-48df-8d60-dae005eece05"
            });
        }
    }
}
