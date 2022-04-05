using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNew_Employeee.Data;
using WebApplicationNew_Employeee.Models;
using WebApplicationNew_Employeee.Services;

namespace WebApplicationNew_Employeee
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Register the Dal AbContext
            //by passing the connection information (connection string)
            //by reading ket form the appsetting.json
            services.AddDbContext<Enterprise1Context>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AppConnStr"));
            });

            services.AddDbContext<WebApplicationNew_EmployeeeContext>(options =>
                   options.UseSqlServer(
                       Configuration.GetConnectionString("WebApplicationNew_EmployeeeContextConnection")));

            services.AddDefaultIdentity<IdentityUser>(
                //options => options.SignIn.RequireConfirmedAccount = true
                )
                .AddEntityFrameworkStores<WebApplicationNew_EmployeeeContext>();


            services.AddScoped<IService<Employee, int>, EmployeeService>();

            services.AddControllersWithViews();
            //Add services to support an exucation of razor pages
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

            //Middaleware for user UseAuthentication
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //Map requiest to razor view for identity pages
                endpoints.MapRazorPages(); //Razor view
            });
        }
    }
}
