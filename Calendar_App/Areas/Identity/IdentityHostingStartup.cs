using System;
using Calendar_App.Areas.Identity.Data;
using Calendar_App.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Calendar_App.Areas.Identity.IdentityHostingStartup))]
namespace Calendar_App.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Calendar_AppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Calendar_AppContextConnection")));

                services.AddDefaultIdentity<Calendar_AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Calendar_AppContext>();
            });
        }
    }
}