using App.Database;
using App.Models;
using App.OpenTelemetry;
using App.Repository;
using App.Server.Admin.Services;
using App.Utils;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.OData;
using Newtonsoft.Json.Serialization;
using Serilog;
using Serilog.AspNetCore;
using Serilog.Exceptions;
using Serilog.Settings.Configuration;

namespace App.Server.Admin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddEnvironmentVariables();

            var configurationAssemblies = new[]
            {
                typeof(ConsoleLoggerConfigurationExtensions).Assembly,
                typeof(FileLoggerConfigurationExtensions).Assembly,
                typeof(LoggerConfigurationTelegramExtensions).Assembly
            };

            var options = new ConfigurationReaderOptions(configurationAssemblies);

            Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .Enrich.WithMachineName()
                    .Enrich.WithExceptionDetails()
                    .Enrich.WithProperty("Environment", builder.Environment)
                    .ReadFrom.Configuration(builder.Configuration, options)
                    .CreateLogger();

            builder.Services.AddControllers(o => { o.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true; })
                            .AddNewtonsoftJson(o => { o.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver(); })
                            .AddOData(o => o.Select().Filter().EnableQueryFeatures(100).OrderBy().SetMaxTop(100).Count().Expand());

            builder.Services.ApiMyVersion();
            builder.Services.AddMySwagger();
            builder.Services.AddSerilog();
            builder.Services.LoadApiPluginsService();
            builder.Services.AddMyResponseCompression();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });
            builder.Services.Configure<RequestLoggingOptions>(o =>
            {
                o.EnrichDiagnosticContext = (d, h) =>
                {
                    d.Set("RemoteIpAddress", h.Connection.RemoteIpAddress.MapToIPv4());
                };
            });

            builder.Services.AddMyVars(builder.Configuration);
            builder.Services.AddMyAuthentication(builder.Configuration);
            builder.Services.AddMemoryCache();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddMyDatabaseService(builder.Configuration);

            builder.Services.AddMyOpenTelemetry(builder.Configuration);
            builder.Services.AddMyOcppService();

            builder.Services.AddScoped<ICRestClient, CRestClient>();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.Configure<Vars>(builder.Configuration.GetSection("Vars"));
            builder.Services.Configure<JwtVars>(builder.Configuration.GetSection("JWT"));

            builder.Services.AddSignalR(hubOptions =>
            {
                hubOptions.EnableDetailedErrors = true;
                hubOptions.KeepAliveInterval = TimeSpan.FromMinutes(1);
            });

            var app = builder.Build();
            app.UseResponseCaching();
            app.UseMySwagger();
            app.UseMyStaticFiles();

            app.UseRouting();
            app.UseCors("AllowAllHeaders");
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto });
            app.MapControllers();

            app.UseMyOpenTelemetry();
            app.UseSerilogRequestLogging();
            app.UseResponseCompression();
            app.UpdateMigrateDatabase();

            app.Run();
        }
    }
}