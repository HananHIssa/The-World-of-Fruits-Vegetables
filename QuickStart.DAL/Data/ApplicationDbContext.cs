using System.Collections.Generic;
using System.Data.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using QuickStart.DAL.Data.Models;

namespace QuickStart.DAL.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			var roleAdminId = Guid.NewGuid().ToString();
			var roleUserId = Guid.NewGuid().ToString();
			var roleSuperId = Guid.NewGuid().ToString();
			base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id= roleAdminId, Name="Admin",NormalizedName="ADMIN"},
			    new IdentityRole { Id = roleUserId, Name = "User", NormalizedName = "USER" },
			    new IdentityRole { Id = roleSuperId, Name = "SuperAdmin", NormalizedName = "SUPERADMINE" }
				);
            var hasher = new PasswordHasher<IdentityUser>();
			var AdminUser = new IdentityUser
			{
				Id = Guid.NewGuid().ToString(),
				UserName = "Adminuser@comp.com",
				NormalizedUserName = "ADMINUSER@COMP.COM",
				Email = "Adminuser@comp.com",
				NormalizedEmail = "ADMINEUSER@COMP.COM",
				EmailConfirmed = true
			};
			AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "Hanan22@123");
			var SuperAdmin = new IdentityUser
			{
				Id = Guid.NewGuid().ToString(),
				UserName = "SuperAdmin@comp.com",
				NormalizedUserName = "SUPERADMIN@COMP.COM",
				Email = "SuperAdmin@comp.com",
				NormalizedEmail = "SUPERADMIN@COMP.COM",
				EmailConfirmed = true
			};
			AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "Hanan22@123");

			var User = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user@comp.com",
                NormalizedUserName = "USER@COMP.COM",
                Email = "user@comp.com",
                NormalizedEmail = "USER@COMP.COM",
                EmailConfirmed = true
			};
			User.PasswordHash = hasher.HashPassword(User, "Hanan@2121");
			builder.Entity<IdentityUser>().HasData(User, SuperAdmin, AdminUser);
			builder.Entity<IdentityUserRole<string>>().HasData(
				new IdentityUserRole<string> { RoleId= roleUserId, UserId=User.Id},
				new IdentityUserRole<string> { RoleId = roleSuperId, UserId = SuperAdmin.Id },
				new IdentityUserRole<string> { RoleId = roleAdminId, UserId = AdminUser.Id }
				);
		}
		public DbSet<Services> Services { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Item> Items { get; set; }

    }

}
