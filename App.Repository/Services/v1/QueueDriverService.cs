using App.Database;
using App.Database.Models;
using App.Models;
using App.Repository.Extensions;
using App.Repository.Models;
using App.Utils;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface IQueueDriverService
    {
        ValueTask<Answer<viQueueDriver[]>> GetByChargePointAsync(int id);
        ValueTask<int> GetCountAsync(ODataQueryOptions<tbQueueDriver> options);
        ValueTask<viQueueDriver[]> GetQueryableAsync(ODataQueryOptions<tbQueueDriver> options);
    }


    public class QueueDriverService : IQueueDriverService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly ILogger<QueueDriverService> logger;
        private readonly MyDbContext db;
        private readonly IMapper mapper;

        public QueueDriverService(ILogger<QueueDriverService> logger, MyDbContext db, IMapper mapper, IOcppHttpContextAccessorExtensions accessor)
        {
            this.db = db;
            this.logger = logger;
            this.mapper = mapper;
            this.accessor = accessor;
        }

        public async ValueTask<viQueueDriver[]> GetQueryableAsync(ODataQueryOptions<tbQueueDriver> options)
        {
            var storage = db.Set<tbQueueDriver>();
            var query = options.ApplyTo(storage.AsNoTracking().Where(x => x.Status == 1).AsQueryable(), AllowedQueryOptions.Supported);

            var cnt = await query.Cast<tbQueueDriver>().ProjectTo<viQueueDriver>(mapper.ConfigurationProvider).ToArrayAsync();
            return cnt;
        }

        public async ValueTask<int> GetCountAsync(ODataQueryOptions<tbQueueDriver> options)
        {
            var storage = db.Set<tbQueueDriver>();
            var query = options.ApplyTo(storage.AsNoTracking().Where(x => x.Status == 1).AsQueryable(), AllowedQueryOptions.Top);

            var cnt = await query.Cast<tbQueueDriver>().CountAsync();
            return cnt;
        }


        public async ValueTask<Answer<viQueueDriver[]>> GetByChargePointAsync(int id)
        {
            try
            {
                var res = await db.tbQueueDrivers.AsNoTracking()
                                    .Where(x => x.Status == 1)
                                    .ProjectTo<viQueueDriver>(mapper.ConfigurationProvider)
                                    .ToArrayAsync();

                if (res == null || res?.Length == 0) return new Answer<viQueueDriver[]>(false, "Маълумот топилмади", null);
                return new Answer<viQueueDriver[]>(true, "", res);
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbQueueDriver GetAllAsync Error:{ee.GetAllMessages()} ");
                return new Answer<viQueueDriver[]>(false, "Тизимда хато", null);
            }
        }

    }
}
