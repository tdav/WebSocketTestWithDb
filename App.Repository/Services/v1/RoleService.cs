using App.Database;
using App.Database.Models;
using App.Models;
using App.Repository.Extensions;
using App.Repository.Models;
using App.Utils;
using App.Utils.Serializable;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface IRoleService
    {
        ValueTask<Answer<string[]>> GetAllRoles();
        ValueTask<Answer<string[]>> GetRolesByUser(Guid userId);
        ValueTask<AnswerBasic> SetRoles(viChangeRole vi);
        ValueTask<AnswerBasic> RemoveRoles(viChangeRole vi);
    }

    public class RoleService : IRoleService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly UserManager<tbUser> userManager;
        private readonly ILogger<RoleService> logger;
        private readonly MyDbContext db;

        public RoleService(MyDbContext db, ILogger<RoleService> logger, UserManager<tbUser> userManager, IOcppHttpContextAccessorExtensions accessor)
        {
            this.db = db;
            this.logger = logger;
            this.userManager = userManager;
            this.accessor = accessor;
        }

        public async ValueTask<Answer<string[]>> GetAllRoles()
        {
            try
            {
                var ls = await db.spRoles.Select(s => s.Name).ToArrayAsync();

                return new Answer<string[]>(true, "", ls);
            }
            catch (Exception ee)
            {
                logger.LogError($"RoleService.GetAllRoles Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new Answer<string[]>(false, "Тизимда хато", null);
            }
        }

        public async ValueTask<Answer<string[]>> GetRolesByUser(Guid userId)
        {
            if (!accessor.IsRoleAdmin())
                return new Answer<string[]>(false, "Ваколатингиз кам", null);

            try
            {
                var us = await db.tbUsers.FirstOrDefaultAsync(x => x.Id == userId);
                if (us == null)
                    return new Answer<string[]>(false, "Фойдаланувчи топилмади", null);


                var ls = await userManager.GetRolesAsync(us);
                return new Answer<string[]>(true, "", ls.ToArray());
            }
            catch (Exception ee)
            {
                logger.LogError($"RoleService.GetRolesByUser Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new Answer<string[]>(false, "Тизимда хато", null);
            }
        }

        public async ValueTask<AnswerBasic> RemoveRoles(viChangeRole vi)
        {
            if (!accessor.IsRoleAdmin())
                return new AnswerBasic(false, "Ваколатингиз кам");

            try
            {
                var us = await db.tbUsers.FirstOrDefaultAsync(x => x.Id == vi.UserId);
                if (us == null)
                    return new AnswerBasic(false, "Фойдаланувчи топилмади");

                for (int i = 0; i < vi.RoleNames.Count; i++)
                {
                    var el = await userManager.RemoveFromRoleAsync(us, vi.RoleNames[i]);

                    if (!el.Succeeded)
                    {
                        string message = "";
                        foreach (var err in el.Errors)
                        {
                            message += err + Environment.NewLine;
                        }

                        return new AnswerBasic(false, message);
                    }
                }

                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"RoleService.RemoveRoleByUser Model:{vi.ToJson()} Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async ValueTask<AnswerBasic> SetRoles(viChangeRole vi)
        {
            if (!accessor.IsRoleAdmin())
                return new AnswerBasic(false, "Ваколатингиз кам");


            try
            {
                var us = await db.tbUsers.FirstOrDefaultAsync(x => x.Id == vi.UserId);
                if (us == null)
                    return new AnswerBasic(false, "Фойдаланувчи топилмади");

                for (int i = 0; i < vi.RoleNames.Count; i++)
                {
                    var el = await userManager.AddToRoleAsync(us, vi.RoleNames[i]);

                    if (!el.Succeeded)
                    {
                        string message = "";
                        foreach (var err in el.Errors)
                        {
                            message += err + Environment.NewLine;
                        }

                        return new AnswerBasic(false, message);
                    }
                }

                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"RoleService.SetRole Model:{vi.ToJson()} Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

    }
}
