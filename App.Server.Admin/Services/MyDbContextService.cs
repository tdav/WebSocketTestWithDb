using App.Database;
using App.Database.Models;
using App.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace App.Server.Admin.Services
{
    public static class MyDbContextService
    {

        public static void UpdateMigrateDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<MyDbContext>())
                {
                    context.Database.Migrate();

                    var um = serviceScope.ServiceProvider.GetService<UserManager<tbUser>>();
                    var rm = serviceScope.ServiceProvider.GetService<RoleManager<spRole>>();

                    SeedAsync(um, rm).GetAwaiter().GetResult();
                }
            }
        }

        private static async Task<bool> SeedAsync(UserManager<tbUser> userManager, RoleManager<spRole> roleManager)
        {
            try
            {
                if (await userManager.FindByIdAsync("d4b563be-8926-46e8-b377-3de7bf096c08") == null)
                {
                    await roleManager.CreateAsync(new spRole { Name = "Администратор" });
                    await roleManager.CreateAsync(new spRole { Name = "Пользователь системы" });
                    await roleManager.CreateAsync(new spRole { Name = "Водители" });
                    await roleManager.CreateAsync(new spRole { Name = "Отчеты" });
                    await roleManager.CreateAsync(new spRole { Name = "Инженер" });
                    await roleManager.CreateAsync(new spRole { Name = "Служба поддержки" });
                    await roleManager.CreateAsync(new spRole { Name = "Системный учетный запись" });

                    var g = Guid.Parse("d4b563be-8926-46e8-b377-3de7bf096c08");
                    var user = new tbUser()
                    {
                        Id = g,
                        Surname = "Admin",
                        Name = "Admin",
                        Patronymic = "Admin",
                        UserName = "998278960",
                        PhoneNumber = "998278960",
                        Verified = true,
                        Status = 1,
                        CreateDate = DateTime.Now,
                        CreateUser = g,
                    };

                    var res = await userManager.CreateAsync(user, "123456");
                    await userManager.AddToRoleAsync(user, "Администратор");


                    var wg = Guid.Parse("46e863be-8926-46e8-b377-3de7bf096c08");
                    var webuser = new tbUser()
                    {
                        Id = wg,
                        Surname = "Web",
                        Name = "Socker",
                        Patronymic = "Server",
                        UserName = "web_socker_server",
                        PhoneNumber = "000000000",
                        Verified = true,
                        Status = 1,
                        CreateDate = DateTime.Now,
                        CreateUser = g,
                    };

                    var res1 = await userManager.CreateAsync(webuser, "Web$0cket9882");
                    await userManager.AddToRoleAsync(webuser, "Администратор");



                    var sysuser = new tbUser()
                    {
                        Id = Guid.Parse("9613d012-c4f5-4986-b885-ca5863e12344"),
                        Surname = "Ручной",
                        Name = "активация",
                        Patronymic = "",
                        UserName = "000000000",
                        PhoneNumber = "000000000",
                        Verified = true,
                        Status = 9,
                        CreateDate = DateTime.Now,
                        CreateUser = g,
                    };

                    var res2 = await userManager.CreateAsync(sysuser, "e4jxttaBA6NWGQw");
                    await userManager.AddToRoleAsync(sysuser, "Системный учетный запись");
                }

                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"MyDbContextService.Seed Error:{ex.GetAllMessages()}");
                return false;
            }

        }
    }
}
