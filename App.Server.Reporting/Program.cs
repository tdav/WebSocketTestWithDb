using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Settings.Configuration;
using System;
using System.Threading;

namespace App.Server.Report
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var culture = new System.Globalization.CultureInfo("ru-RU");
            var df = new System.Globalization.CultureInfo("ru-RU");
            culture.NumberFormat = df.NumberFormat;
            culture.DateTimeFormat = df.DateTimeFormat;
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            var configurationAssemblies = new[] { typeof(ConsoleLoggerConfigurationExtensions).Assembly, typeof(FileLoggerConfigurationExtensions).Assembly };
            var options = new ConfigurationReaderOptions(configurationAssemblies);


            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(x =>
                    {
                        x.UseKestrel();
                        x.UseStartup<Startup>();
                    })
                .UseSerilog((hostingContext, services, x) => x.ReadFrom.Configuration(hostingContext.Configuration, options))
                .Build()
                .Run();
        }
    }
}
