using App.Repository.Extensions;
using App.Repository.Services.v1;
using Microsoft.Extensions.DependencyInjection;


namespace App.Repository
{
    public static class DependencyInjection
    {
        public static void AddMyOcppService(this IServiceCollection services)
        {
            services.AddScoped<IOcppHttpContextAccessorExtensions, OcppHttpContextAccessorExtensions>();

            services.AddScoped<IDistrictService, DistrictService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IQueueDriverService, QueueDriverService>();
            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<IUnitService, UnitService>();
            services.AddScoped<IUserIdentityService, UserIdentityService>();
        }
    }
}
