using App.Server.Report.Services;
using Microsoft.Extensions.DependencyInjection;

namespace App.Server.Report.Extensions
{
    public static class MyService
    {
        public static void AddMyService(this IServiceCollection services)
        {
            services.AddScoped<IReportsInfoService, ReportsInfoService>();
            services.AddTransient<CustomDashboardFileStorage>();
        }
    }
}
