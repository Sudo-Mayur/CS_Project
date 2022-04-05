using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationNew_Employeee.Data;

[assembly: HostingStartup(typeof(WebApplicationNew_Employeee.Areas.Identity.IdentityHostingStartup))]
namespace WebApplicationNew_Employeee.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<WebApplicationNew_EmployeeeContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("WebApplicationNew_EmployeeeContextConnection")));

            //    services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<WebApplicationNew_EmployeeeContext>();
            //});
        }
    }
}
