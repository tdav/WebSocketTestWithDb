using App.Database;
using App.Database.Models;
using App.Models;
using App.Repository.Extensions;
using App.Utils;
using App.Utils.Serializable;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface ISystemSettingsService
    {
        ValueTask<Answer<tbSystemSetting>> GetByIdAsync(int id);
        ValueTask<AnswerBasic> InsertAsync(tbSystemSetting value);
        ValueTask<AnswerBasic> UpdateAsync(tbSystemSetting value);
        ValueTask<AnswerBasic> DeleteAsync(int id);
    }

    public class SystemSettingsService : ISystemSettingsService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly ILogger<SystemSettingsService> logger;
        private readonly MyDbContext db;

        public SystemSettingsService(MyDbContext db, ILogger<SystemSettingsService> logger, IOcppHttpContextAccessorExtensions accessor)
        {
            this.db = db;
            this.logger = logger;
            this.accessor = accessor;
        }

        public async ValueTask<Answer<tbSystemSetting>> GetByIdAsync(int id)
        {
            try
            {
                var res = await db.tbSystemSettings.AsNoTracking()
                                  .FirstOrDefaultAsync(x => x.Id == id);
                if (res == null) return new Answer<tbSystemSetting>(false, "Маълумот топилмади", null);
                return new Answer<tbSystemSetting>(true, "", res);
            }
            catch (Exception ee)
            {
                logger.LogError($"SystemSettingsService.GetByIdAsync Id:{@id} Error:{ee.GetAllMessages()}");
                return new Answer<tbSystemSetting>(false, "Тизимда хато", null);
            }
        }

        public async ValueTask<AnswerBasic> InsertAsync(tbSystemSetting value)
        {
            try
            {
                value.CreateDate = DateTime.Now;
                value.CreateUser = accessor.GetId();
                value.Status = 1;

                await db.tbSystemSettings.AddAsync(value);
                await db.SaveChangesAsync();
                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"SystemSettingsService.InsertAsync Model:{value.ToJson()} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async ValueTask<AnswerBasic> UpdateAsync(tbSystemSetting value)
        {
            try
            {
                var cc = await db.tbSystemSettings.FirstOrDefaultAsync(x => x.Id == value.Id);
                if (cc == null) return new AnswerBasic(false, "Маълумот топилмади");

                cc.Name = value.Name;
                cc.JsonData = value.JsonData;
                cc.Status = value.Status;
                cc.UpdateDate = DateTime.Now;
                cc.UpdateUser = accessor.GetId();
                await db.SaveChangesAsync();
                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"SystemSettingsService.Update Model:{value.ToJson()} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async ValueTask<AnswerBasic> DeleteAsync(int id)
        {
            try
            {
                var it = await db.tbSystemSettings.FirstOrDefaultAsync(x => x.Id == id);
                it.Status = 0;
                await db.SaveChangesAsync();
                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"SystemSettingsService.Delete Id:{id} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }
    }
}
