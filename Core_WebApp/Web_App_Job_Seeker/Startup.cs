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
using Web_App_Job_Seeker.Data;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;

namespace Web_App_Job_Seeker
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
            services.AddDbContext<CompanyContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AppConnStr"));
            });


            services.AddDbContext<Web_App_Job_SeekerContext>(options =>
                   options.UseSqlServer(
                       Configuration.GetConnectionString("Web_App_Job_SeekerContextConnection")));

            //services.AddDefaultIdentity<IdentityUser>(//options => 
            //options.SignIn.RequireConfirmedAccount = true
            // )
            //.AddEntityFrameworkStores<Web_App_Job_SeekerContext>();

            // REgistration of 
            // UserManager<IdentityUser>
            // RoleManager<IdentityRole>
            // SignInManager<IdenttyUser>
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<Web_App_Job_SeekerContext>().AddDefaultUI();


            services.AddAuthorization(options => {
                options.AddPolicy("EmployeerPolicy", policy => {
                    policy.RequireRole("Employeer");
                });
                options.AddPolicy("JobSeekerPolicy", policy =>
                {
                    policy.RequireRole("JobSeeker");
                });

                //options.AddPolicy("ManagerPolicy", policy =>
                //{
                //    policy.RequireRole("Manager");
                //});

            });



            //register the custom service those contains Bisinnes logic
            //service interface , classs implementing service interface
            services.AddScoped<IService<PersonalInfo, int>, PersonalInfoService>();
            services.AddScoped<IService<EducationalInfo, int>, EducationalInfoService>();
            services.AddScoped<IService<ProfessionalInfo, int>, ProfessionalInfoService>();
            services.AddScoped<IService<Employeer, int>, EmployeerServices>();



            // COfigure Sessions
            // The Session Time out is 20 Mins for Idle Request
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            });



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

            // Use the Sessin Middleware
            app.UseSession();

            //Middaleware for user UseAuthentication
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages(); //Razor view
            });
        }
    }
}
