using App.Database;
using App.Models;
using App.Repository.Models;
using App.Utils;
using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface IDashboardService
    {
        ValueTask<Answer<viDashboardModel>> GetAsync(viDashboardRequest vi);
    }


    public partial class DashboardService : IDashboardService
    {
        private readonly ILogger<DashboardService> logger;
        private readonly IMemoryCache memoryCache;
        private readonly MyDbContext db;
        private readonly IMapper mapper;

        public DashboardService(IMapper mapper, MyDbContext db, IMemoryCache memoryCache, ILogger<DashboardService> logger)
        {
            this.mapper = mapper;
            this.db = db;
            this.memoryCache = memoryCache;
            this.logger = logger;
        }

        public async ValueTask<Answer<viDashboardModel>> GetAsync(viDashboardRequest vi)
        {
            try
            {
                var ls = viDashboardModel.Create();
                ls.LiveNetworkLoadPie = await GetLiveNetworkLoadPieAsync();

                return new Answer<viDashboardModel>(true, "", ls);

            }
            catch (Exception ee)
            {
                logger.LogError($"DashboardService GetAsync Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(5)}");
                return new Answer<viDashboardModel>(false, "Тизимда хато", null);
            }
        }

        private async ValueTask<viLiveNetworkLoadPie> GetLiveNetworkLoadPieAsync()
        {
            try
            {
                var sql = @"select sum( t1.kilo_watt )  FROM public.tb_meter_values t1
                                JOIN (SELECT charge_point_id, connector_id , MAX(id) id 
  		                                FROM public.tb_meter_values GROUP BY charge_point_id, connector_id) t2
		                                ON t1.charge_point_id = t2.charge_point_id and t1.connector_id = t2.connector_id AND t1.id = t2.id";

                var cur = await db.GetDbConnection().QuerySingleAsync<int>(sql);
                var max = await GetThroughput();

                return new viLiveNetworkLoadPie() { CurrentValue = cur, MaxValue = max };
            }
            catch (Exception ee)
            {
                logger.LogError($"DashboardService GetAsync Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(5)}");
                return null;
            }
        }

        private async ValueTask<int> GetThroughput()
        {
            try
            {
                int throughput = 0;
                if (memoryCache.TryGetValue("MAX_THROUGHPUT", out throughput))
                {
                    return throughput;
                }
                else
                {
                    throughput = await db.tbConnectors
                                         .AsNoTracking()
                                         .Include(i => i.ConnectorType)
                                         .SumAsync(m => m.Throughput);
                    memoryCache.Set("MAX_THROUGHPUT", throughput, TimeSpan.FromMinutes(1));
                }

                return throughput;

            }
            catch (Exception ee)
            {
                logger.LogError($"DashboardService GetThroughput Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(5)}");
                return 0;
            }
        }
    }
}
