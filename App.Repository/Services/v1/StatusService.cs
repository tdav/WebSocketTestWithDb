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
    public interface IStatusService
    {
        ValueTask<Answer<spStatus[]>> GetAllAsync();
    }

    public class StatusService : IStatusService
    {
        private readonly ILogger<StatusService> logger;
        private readonly MyDbContext db;
        private readonly IMapper mapper;

        public StatusService(ILogger<StatusService> logger, MyDbContext db, IMapper mapper)
        {
            this.db = db;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async ValueTask<Answer<spStatus[]>> GetAllAsync()
        {
            try
            {

                var ls = await db.spStatuses.AsNoTracking()
                                                .Where(x => x.Status == 1)
                                                .Cacheable()
                                                .ToArrayAsync();

                return new Answer<spStatus[]>(true, "", ls);

            }
            catch (Exception ee)
            {
                logger.LogError($"StatusService GetAsync Error:{ee.GetAllMessages()} ");
                return new Answer<spStatus[]>(false, "Тизимда хато", null);
            }
        }
    }
}
