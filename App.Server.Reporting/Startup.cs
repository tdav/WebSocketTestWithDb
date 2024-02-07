using App.Database;
using App.OpenTelemetry;
using App.Server.Report.Extensions;
using App.Server.Report.Models;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.DashboardAspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Collections.Generic;

namespace App.Server.Report
{
    public class Startup
    {
        public IConfiguration conf { get; }
        public IWebHostEnvironment webHostEnvironment { get; }


        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            conf = configuration;
            webHostEnvironment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var section = conf.GetSection("SystemVars");
            services.Configure<Vars>(section);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                        builder =>
                        {
                            builder.AllowAnyOrigin()
                                   .AllowAnyHeader()
                                   .AllowAnyMethod();
                        });
            });

            services.AddControllersWithViews();
            services.AddMvc().AddNewtonsoftJson();
            services.AddRazorPages();

            services.AddMyOpenTelemetry(conf);

            services.AddDevExpressControls();
            services.AddMyReportsService(webHostEnvironment.IsDevelopment());
            services.AddDashboardService(conf);

            services.AddResponseCompression();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMyDatabaseService(conf);

            DevExpress.Utils.DeserializationSettings.RegisterTrustedClass(typeof(DevExpress.DataAccess.Sql.SqlDataConnection));

            services.ApiMyVersion();
            services.AddMyAuthentication(conf);
            services.AddMemoryCache();
            services.AddMyService();
            services.AddMySwagger();

            services.ConfigureReportingServices(configurator => { configurator.UseDevelopmentMode(); });

            //if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            //{
            //    DevExpress.Drawing.Internal.DXDrawingEngine.ForceSkia();
            //}
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
            app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.StartsWithSegments("/swagger")) await next();
                else
                {
                    var token = context.Request.Cookies["ocpp-user-token"];
                    if (!string.IsNullOrEmpty(token) && string.IsNullOrEmpty(context.Request.Headers.Authorization))
                        context.Request.Headers.TryAdd("Authorization", "Bearer " + token);

                    await next();
                }
            });

            app.UseResponseCompression();


            var supportedCultures = new[] { "ru-RU", "en-US" };
            var opts = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0]).AddSupportedCultures(supportedCultures).AddSupportedUICultures(supportedCultures);
            opts.RequestCultureProviders.Clear();
            app.UseRequestLocalization(opts);

            app.UseDevExpressControls();
            app.UseCookiePolicy();
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors("AllowAllHeaders");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapDashboardRoute("dashboardControl", "DefaultDashboard");
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");
            });

            app.UseMyOpenTelemetry();
            app.UseMyReportsService(env);
            app.UseSerilogRequestLogging();
            app.UseMySwagger();

        }
    }
}
