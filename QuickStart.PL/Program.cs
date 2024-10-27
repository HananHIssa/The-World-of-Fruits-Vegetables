using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using QuickStart.DAL.Data;
using QuickStart.PL.Mapping;

namespace QuickStart.DAL
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
				?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

			builder.Services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connectionString));
			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			// Add Identity services with roles
			builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
				options.SignIn.RequireConfirmedAccount = false)
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();

			// Add AutoMapper
			builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(MappingProfile)));

			// Add Razor Pages and Controllers with Views
			builder.Services.AddRazorPages();
			builder.Services.AddControllersWithViews();

			// Add EmailSender service (Mock)
			builder.Services.AddSingleton<IEmailSender, MockEmailSender>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			// Authentication & Authorization
			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "areas",
				pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
			);

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}"
			);

			app.MapRazorPages();

			// Run the app
			app.Run();
		}
	}

	// MockEmailSender class implementation
	public class MockEmailSender : IEmailSender
	{
		public Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			// Here you can add logic to simulate sending an email, like writing to the console
			Console.WriteLine($"Sending email to: {email}, subject: {subject}");
			return Task.CompletedTask;
		}
	}
}
