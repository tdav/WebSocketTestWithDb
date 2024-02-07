using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace App.Database
{
    public class MyUsersDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var conf = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .AddEnvironmentVariables()
                .Build();

            var str = conf.GetConnectionString("OcppDbConnectionString");
            var options = new DbContextOptionsBuilder<MyDbContext>();
            options.UseNpgsql(str)
                .UseSnakeCaseNamingConvention()
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging();

            return new MyDbContext(options.Options);
        }
    }
}
