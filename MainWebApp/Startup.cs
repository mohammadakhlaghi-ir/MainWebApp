using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using MainWebApp.Controllers;
using Entity;
using Microsoft.EntityFrameworkCore;
using Entity.Models;
using Core.Interfaces;
using Core.Services;
namespace MainWebApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<MainDbContext>(options =>
              options.UseSqlServer(connectionString));
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }
               ).AddCookie(options =>
               {
                   options.Cookie.HttpOnly = true;
                   options.LoginPath = "/Login";
                   options.AccessDeniedPath = "/AccessDenied";
               });

            #region Contollers Scoped
            services.AddScoped<HomeController>();
            #endregion

            #region Services Scoped
            services.AddScoped<IAppInfo, AppInfoServices>();
            #endregion
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseStatusCodePagesWithRedirects("/Error/{0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
