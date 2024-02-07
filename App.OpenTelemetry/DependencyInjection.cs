using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenTelemetry.Instrumentation.AspNetCore;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace App.OpenTelemetry
{

    //https://grafana.com/grafana/dashboards/17706-asp-net-otel-metrics/
    public static class DependencyInjection
    {
        public static void AddMyOpenTelemetry(this IServiceCollection services, IConfiguration conf)
        {
            services.Configure<AspNetCoreTraceInstrumentationOptions>(options =>
            {
                options.Filter = ctx => ctx.Request.Path != "/metrics";
            });

            services.AddOpenTelemetry()
                  .ConfigureResource(b => { b.AddService(AppDomain.CurrentDomain.FriendlyName); })
                  .WithMetrics(b =>
                  {
                      if (conf["OpenTelemetry:AspNetCoreInstrumentation"] == "1") b.AddAspNetCoreInstrumentation();
                      if (conf["OpenTelemetry:HttpClientInstrumentation"] == "1") b.AddHttpClientInstrumentation();
                      if (conf["OpenTelemetry:RuntimeInstrumentation"] == "1") b.AddRuntimeInstrumentation();
                      if (conf["OpenTelemetry:ProcessInstrumentation"] == "1") b.AddProcessInstrumentation();

                      b.AddPrometheusExporter(opt =>
                      {
                          opt.ScrapeEndpointPath = "/metrics";
                      });

                  });
        }

        public static void UseMyOpenTelemetry(this IApplicationBuilder app)
        {
            app.UseOpenTelemetryPrometheusScrapingEndpoint();
            // app.UseHttpLogging();

        }
    }
}
