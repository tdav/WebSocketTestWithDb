using App.Repository.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace App.Server.Report.Extensions
{
    public static class AuthenticationService
    {
        public static void AddMyAuthentication(this IServiceCollection services, IConfiguration conf)
        {
            services
              .AddHttpContextAccessor()
              .AddScoped<IOcppHttpContextAccessorExtensions, OcppHttpContextAccessorExtensions>()
              .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
              .AddJwtBearer(options =>
              {
                  options.RequireHttpsMetadata = false;
                  options.TokenValidationParameters = new TokenValidationParameters
                  {
                      ValidateIssuer = false,
                      //ValidIssuer = AuthOptions.ISSUER,
                      ValidateAudience = false,
                      //ValidAudience = AuthOptions.AUDIENCE,
                      ValidateLifetime = true,
                      IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(conf["JWT:Secret"])),
                      ValidateIssuerSigningKey = true,
                  };
              });
        }
    }
}
