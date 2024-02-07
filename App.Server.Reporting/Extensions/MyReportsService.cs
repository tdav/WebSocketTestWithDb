using App.Server.Report.Services;
using DevExpress.AspNetCore.Reporting;
using DevExpress.Security.Resources;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace App.Server.Report.Extensions
{
    public static class MyReportsService
    {
        public static void AddMyReportsService(this IServiceCollection services, bool isDevelopment)
        {
            services.AddScoped<ReportStorageWebExtension, FileReportStorageWebExtension>();
            services.ConfigureReportingServices(configurator =>
            {
                if (isDevelopment) configurator.UseDevelopmentMode();

                configurator.UseAsyncEngine();

                configurator.ConfigureReportDesigner(designerConfigurator =>
                {
                    designerConfigurator.RegisterDataSourceWizardConnectionStringsProvider<ReportsSqlDataSourceWizardConnectionStringsProvider>();
                    designerConfigurator.RegisterDataSourceWizardJsonConnectionStorage<ReportsDataSourceWizardJsonDataConnectionStorage>(true);
                });

                configurator.ConfigureWebDocumentViewer(viewerConfigurator =>
                {
                    viewerConfigurator.UseCachedReportSourceBuilder();
                    viewerConfigurator.RegisterJsonDataConnectionProviderFactory<ReportsJsonDataConnectionProviderFactory>();
                    viewerConfigurator.RegisterConnectionProviderFactory<ReportsSqlDataConnectionProviderFactory>();
                });
            });
        }


        public static void UseMyReportsService(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            var supportedCultures = new[] { "ru-RU", "en-US" };
            var opts = new RequestLocalizationOptions()
                .SetDefaultCulture(supportedCultures[0])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            opts.RequestCultureProviders.Clear();
            app.UseRequestLocalization(opts);

            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;

            ReportStorageWebExtension.RegisterExtensionGlobal(new FileReportStorageWebExtension(env));
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DataBindingMode.Expressions;

            var contentDirectoryAllowRule = DirectoryAccessRule.Allow(new DirectoryInfo(Path.Combine(env.ContentRootPath, "..", "Content")).FullName);
            AccessSettings.ReportingSpecificResources.TrySetRules(contentDirectoryAllowRule, UrlAccessRule.Allow());
        }
    }
}
