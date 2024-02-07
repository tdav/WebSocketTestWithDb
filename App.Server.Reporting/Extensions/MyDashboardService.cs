using App.Repository.Extensions;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Xml.Linq;

namespace App.Server.Report.Extensions
{
    public static class MyDashboardService
    {
        public static void AddDashboardService(this IServiceCollection services, IConfiguration conf)
        {

            DashboardExportSettings.CompatibilityMode = DashboardExportCompatibilityMode.Restricted;
            services.AddScoped((serviceProvider) =>
            {
                return DashboardUtils.CreateDashboardConfigurator(serviceProvider, conf);

            });
        }
    }

    public class CustomDashboardFileStorage : DashboardFileStorage
    {
        private readonly IHttpContextAccessor сontextAccessor;

        public CustomDashboardFileStorage(IWebHostEnvironment hostingEnvironment, IHttpContextAccessor contextAccessor)
            : base(hostingEnvironment.ContentRootFileProvider.GetFileInfo("App_Data/Dashboards").PhysicalPath)
        {
            сontextAccessor = contextAccessor;
        }

        protected override XDocument LoadDashboard(string dashboardID)
        {
            return base.LoadDashboard(dashboardID);
        }
    }

    public static class DashboardUtils
    {
        public static DashboardConfigurator CreateDashboardConfigurator(IServiceProvider service, IConfiguration conf)
        {
            var configurator = new DashboardConfigurator();
            configurator.SetConnectionStringsProvider(new DashboardConnectionStringsProvider(conf));
            configurator.SetDashboardStorage(service.GetService<CustomDashboardFileStorage>());

            var contextAccessor = service.GetService<IOcppHttpContextAccessorExtensions>();

            configurator.CustomParameters += (s, e) =>
            {
                e.Parameters.Add(new DashboardParameter("LoggedUser", typeof(string), contextAccessor.GetUserFullName()));
            };

            return configurator;

        }
    }
}
