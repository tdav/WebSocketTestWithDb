using App.Database;
using App.Database.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace App.Server.Admin.Services
{
    public static class AuthenticationService
    {
        public static void AddMyAuthentication(this IServiceCollection services, IConfiguration conf)
        {
            services.AddIdentity<tbUser, spRole>(o =>
            {
                o.Password.RequiredLength = 4;
                o.Password.RequireUppercase = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireDigit = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredUniqueChars = 1;

            }).AddRoles<spRole>()
            .AddEntityFrameworkStores<MyDbContext>()
            .AddDefaultTokenProviders();


            services.AddAuthorization(options =>
            {
                //Yarp.ReverseProxy - учун кушилган
                options.AddPolicy("authenticated", policy => policy.RequireAuthenticatedUser());

                options.AddPolicy(JwtBearerDefaults.AuthenticationScheme, policy =>
                {
                    policy.AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme);
                    policy.RequireClaim(ClaimTypes.NameIdentifier);
                });
            });

            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie()
            .AddJwtBearer(options =>
            {
                //options.SaveToken = true;
                //options.RequireHttpsMetadata = false;
                //options.TokenValidationParameters = new TokenValidationParameters()
                //{
                //    //ValidateIssuer = true,
                //    //ValidateAudience = true,
                //    //ValidateLifetime = true,
                //    //ValidateIssuerSigningKey = true,
                //    //ClockSkew = TimeSpan.Zero,

                //    ValidAudience = conf["JWT:ValidAudience"],
                //    ValidIssuer = conf["JWT:ValidIssuer"],
                //    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(conf["JWT:Secret"]))
                //};

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    LifetimeValidator = (before, expires, token, parameters) => expires > DateTime.UtcNow,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateActor = false,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(conf["JWT:Secret"]))
                };

                options.Events = new JwtBearerEvents
                {

                    // SignalR Auth
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];
                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments("/signal_actions"))
                        {
                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };
            });

        }
    }
}
