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

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Add roles
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
            
            // Create base users
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

            //Connect roles to users
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "0",
                UserId = "b167495c-7b90-4b05-8dc8-256823348341"
            });


            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "b9dacebc-402e-48df-8d60-dae005eece05"
            });

            // Section names
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                CodeWord = "PageNews",
                Title = "Новини"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                CodeWord = "PageBooks",
                Title = "Аудіо-книги"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                CodeWord = "PageMedia",
                Title = "Медіа"
            });
        }
    }
}
