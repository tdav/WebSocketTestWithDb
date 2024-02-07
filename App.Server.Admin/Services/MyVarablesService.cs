using App.Models;

namespace App.Server.Admin.Services
{
    public static class MyVarablesService
    {
        public static void AddMyVars(this IServiceCollection services, IConfiguration conf)
        {
            services.Configure<VarsOcppLog>(o =>
            {
                o.OcppJson = conf["Logging:LogLevel:OcppJson"] == "Information";
                o.OcppMessage = conf["Logging:LogLevel:OcppMessage"] == "Information";
            });
        }
    }
}
