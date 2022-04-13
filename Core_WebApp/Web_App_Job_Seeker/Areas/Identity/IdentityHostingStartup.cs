using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Web_App_Job_Seeker.Data;

[assembly: HostingStartup(typeof(Web_App_Job_Seeker.Areas.Identity.IdentityHostingStartup))]
namespace Web_App_Job_Seeker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<Web_App_Job_SeekerContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("Web_App_Job_SeekerContextConnection")));

            //    services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<Web_App_Job_SeekerContext>();
            //});
        }
    }
}
