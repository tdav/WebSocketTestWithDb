using App.Database;
using App.Database.Models;
using App.Models;
using App.Utils;
using AutoMapper;
using EFCoreSecondLevelCacheInterceptor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface IRegionService
    {
        ValueTask<Answer<spRegion[]>> GetAllAsync();
    }

    public class RegionService : IRegionService
    {
        private readonly ILogger<RegionService> logger;
        private readonly MyDbContext db;
        private readonly IMapper mapper;

        public RegionService(ILogger<RegionService> logger, MyDbContext db, IMapper mapper)
        {
            this.db = db;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async ValueTask<Answer<spRegion[]>> GetAllAsync()
        {
            try
            {

                var ls = await db.spRegions.AsNoTracking()
                                                .Where(x => x.Status == 1)
                                                .Cacheable()
                                                .ToArrayAsync();

                return new Answer<spRegion[]>(true, "", ls);

            }
            catch (Exception ee)
            {
                logger.LogError($"HistoryService GetAsync Error:{ee.GetAllMessages()} ");
                return new Answer<spRegion[]>(false, "Тизимда хато", null);
            }
        }
    }
}
