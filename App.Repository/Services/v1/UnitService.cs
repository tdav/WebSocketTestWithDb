using App.Database;
using App.Database.Models;
using App.Models;
using App.Repository.Extensions;
using App.Utils;
using EFCoreSecondLevelCacheInterceptor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{

    public interface IUnitService
    {
        ValueTask<Answer<spUnit[]>> GetAllAsync();
        ValueTask<Answer<spUnit>> GetByIdAsync(string id);
    }

    public class UnitService : IUnitService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly ILogger<UnitService> logger;
        private readonly MyDbContext db;
        private readonly Vars vars;

        public UnitService(ILogger<UnitService> logger, MyDbContext db)
        {
            this.logger = logger;
            this.db = db;
        }

        public async ValueTask<Answer<spUnit[]>> GetAllAsync()
        {
            try
            {
                var res = await db.spUnits.AsNoTracking()
                                          .Where(x => x.Status == 1)
                                          .Cacheable()
                                          .ToArrayAsync();

                if (res == null || res?.Length == 0)
                    return new Answer<spUnit[]>(false, "Маълумот топилмади", null);
                else
                    return new Answer<spUnit[]>(true, "", res);
            }
            catch (Exception ee)
            {
                logger.LogError($"spUnit.GetAllAsync Repository:{nameof(spUnit)} Error:{ee.GetAllMessages()} ");
                return new Answer<spUnit[]>(false, "Тизимда хато", null);
            }
        }

        public async ValueTask<Answer<spUnit>> GetByIdAsync(string id)
        {
            try
            {
                var res = await db.spUnits.AsNoTracking()
                                          .Where(x => x.Id == id.ToInt())
                                          .Cacheable()
                                          .FirstOrDefaultAsync();

                if (res == null)
                    return new Answer<spUnit>(false, "Маълумот топилмади", null);
                else
                    return new Answer<spUnit>(true, "", res);

            }
            catch (Exception ee)
            {
                logger.LogError($"spUnit.GetByIdAsync Repository:{nameof(spUnit)} Id:{@id} Error:{ee.GetAllMessages()} ");
                return new Answer<spUnit>(false, "Тизимда хато", null);
            }
        }
    }
}
