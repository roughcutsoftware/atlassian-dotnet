using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Roughcut.Atlassian.Interfaces.AppConfig;
using Roughcut.Atlassian.Interfaces.Services;
//using Roughcut.Atlassian.Mvc.Web.Data;

namespace Roughcut.Atlassian.Mvc.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            ////
            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(connectionString));

            ////
            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            //
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // add razor pages
            builder.Services.AddRazorPages();

            //
            builder.Services.AddControllersWithViews();

            // add secrets service
            builder.Services.AddSingleton<SecretsService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
