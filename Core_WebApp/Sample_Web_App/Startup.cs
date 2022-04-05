//using Core_WebApp.CustomFilters;
using Core_WebApp.CustomFilters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC_Assignments.CustomFilters;
using Sample_Web_App.Data;
using Sample_Web_App.Models;
using Sample_Web_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Sample_Web_App
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


            //The Gegistration of the SecurityDbContext into the dependency container
            services.AddDbContext<SecurityDbContext>(options =>
                   options.UseSqlServer(
                       Configuration.GetConnectionString("SecurityDbContextConnection")));
            //Regfister the identity provider classes in dependency container
            //Usermanager<IdentityUser>: User management (CRUD)
            //SigninManager <IdentityUser>: User Login Management
            services.AddDefaultIdentity<IdentityUser>(//options =>
            //Navigate to the conform email page when new user is register
            //options.SignIn.RequireConfirmedAccount = true
            )
            
                //Connet to DataBase fpr security using EF Core
                .AddEntityFrameworkStores<SecurityDbContext>();


            //register the custom service those contains Bisinnes logic
            //service interface , classs implementing service interface
            services.AddScoped<IService<Department, int>, DepartmentService>();
            services.AddScoped<IService<Employee, int>, EmployeeService>();
            services.AddScoped<IService<UserInfo, int>, UserService>();

            // COnfigure the Memory Cache
            // THe Same memory where the Host is executing 
            // the Application
            services.AddMemoryCache();

            // COfigure Sessions
            // The Session Time out is 20 Mins for Idle Request
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            });



            // Process the Request for API and Views both 
            // for MVC
            // THis is is used to Register Filters at Global Level
            services.AddControllersWithViews(options =>
            {
                //options.Filters.Add(typeof(LogFilterAttribute));
                //Comment because of razor view
                // options.Filters.Add(new LogFilterAttribute());

                // REgister the Exception Filter
                // The IModelMetadataProvider will be resolved by the 
                // PIpeline
                //Comment because of razor view
                //options.Filters.Add(typeof(AppExceptionFilterAttribute));
            });
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

            // Generate ROute Table for 
            // All Controllers (MVC and API)
            app.UseRouting();

            // Use the Sessin Middleware
            app.UseSession();
            //Middaleware for user UseAuthentication
            app.UseAuthentication();
            app.UseAuthorization();


            //Map the incoming request with thw controller(MVC and API)
            //Map the incoming requiest with razor view
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

