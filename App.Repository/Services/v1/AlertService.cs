using App.Database;
using App.Database.Models;
using App.Models;
using App.Utils;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface IAlertService
    {
        ValueTask<Answer<tbAlert[]>> GetLastAsync();
        ValueTask<tbAlert[]> GetAllAsync(ODataQueryOptions<tbAlert> options);
        ValueTask<int> GetCountAsync(ODataQueryOptions<tbAlert> options);
        void Insert(string mes, int priority, string chargePointId, string connectorId, string value);
    }


    public class AlertService : IAlertService
    {
        private readonly ILogger<AlertService> logger;
        private readonly MyDbContext db;

        public AlertService(MyDbContext db, ILogger<AlertService> logger)
        {
            this.db = db;
            this.logger = logger;
        }

        public async ValueTask<Answer<tbAlert[]>> GetLastAsync()
        {
            try
            {
                var sql = @"SELECT t1.* FROM  public.tb_alerts t1
                               JOIN 
                                (
                                    SELECT charge_point_id, connector_id, MAX(create_date) create_date 
                                        FROM public.tb_alerts GROUP BY charge_point_id, connector_id
                                ) t2
                                ON t1.charge_point_id = t2.charge_point_id and  
                                   t1.connector_id = t2.connector_id AND 
                                   t1.create_date = t2.create_date";

                var res = db.tbAlerts.FromSqlRaw(sql);
                var ls = await res.ToArrayAsync();

                return new Answer<tbAlert[]>(true, "", ls);
            }
            catch (Exception ee)
            {
                logger.LogError($"AlertService GetAsync Error:{ee.GetAllMessages()}  Stack:{ee.GetStackTrace(5)}");
                return new Answer<tbAlert[]>(false, "Тизимда хато", null);
            }
        }

        public async ValueTask<tbAlert[]> GetAllAsync(ODataQueryOptions<tbAlert> options)
        {
            try
            {
                var storage = db.Set<tbAlert>();
                var query = options.ApplyTo(storage.AsNoTracking().AsQueryable(), AllowedQueryOptions.Supported);
                var cnt = await query.Cast<tbAlert>().OrderByDescending(o => o.Id).ToArrayAsync();
                return cnt;
            }
            catch (Exception ee)
            {
                logger.LogError($"AlertService GetLastAsync Error:{ee.GetAllMessages()}  Stack:{ee.GetStackTrace(5)}");
                return null;
            }
        }

        public async ValueTask<int> GetCountAsync(ODataQueryOptions<tbAlert> options)
        {
            var storage = db.Set<tbAlert>();
            var query = options.ApplyTo(storage.AsNoTracking().AsQueryable(), AllowedQueryOptions.Top);

            var cnt = await query.Cast<tbAlert>().CountAsync();
            return cnt;
        }

        public void Insert(string mes, int priority, string chargePointId, string connectorId, string json)
        {
            try
            {
                var alert = new tbAlert()
                {
                    Name = mes,
                    Priority = priority,
                    ChargePointId = chargePointId,
                    ConnectorId = string.IsNullOrWhiteSpace(connectorId) ? -1 : connectorId.ToInt(),
                    JsonData = string.IsNullOrWhiteSpace(json) ? null : json,
                    CreateDate = DateTime.Now,
                };
                db.tbAlerts.Add(alert);
                db.SaveChanges();
            }
            catch (Exception ee)
            {
                logger.LogError($"AlertService GetAsync Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(5)}");
            }
        }
    }
}
