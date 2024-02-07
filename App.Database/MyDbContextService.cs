using EFCoreSecondLevelCacheInterceptor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace App.Database
{
    public static class MyDbContextService
    {
        public static void AddMyDatabaseService(this IServiceCollection services, IConfiguration conf)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var connStr = conf.GetConnectionString("OcppDbConnectionString");
            services.AddDbContextPool<MyDbContext>((serviceProvider, o) =>
            {
                o.UseNpgsql(connStr)
                 .UseSnakeCaseNamingConvention()
                 .EnableDetailedErrors()
                 .EnableSensitiveDataLogging()
                 .AddInterceptors(serviceProvider.GetRequiredService<SecondLevelCacheInterceptor>());
            });

            services.AddMyEFSecondLevelCache(conf);
        }
    }
}
