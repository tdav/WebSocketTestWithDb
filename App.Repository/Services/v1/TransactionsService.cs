using App.Database;
using App.Database.Models;
using App.Models;
using App.Repository.Extensions;
using App.Repository.Models;
using App.Utils;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dapper;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface ITransactionsService
    {
        ValueTask<viTransaction[]> GetAllAsync(ODataQueryOptions<tbTransaction> options);
        ValueTask<int> GetCountAsync(ODataQueryOptions<tbTransaction> options);
        ValueTask<Answer<viTransactionCurrent>> GetCurrentAsync();

        ValueTask<int?> GetTransactionIdAsync(string chargePointNameId);

        ValueTask<Answer<tbTransaction[]>> GetMyHistoryAsync();
        viIdValue CalcCarInfoAvg(int transactionId);
    }


    public class TransactionsService : ITransactionsService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly ILogger<TransactionsService> logger;
        private readonly MyDbContext db;
        private readonly IMapper mapper;

        public TransactionsService(IMapper mapper, MyDbContext db, ILogger<TransactionsService> logger, IOcppHttpContextAccessorExtensions accessor)
        {
            this.mapper = mapper;
            this.db = db;
            this.logger = logger;
            this.accessor = accessor;
        }


        public async ValueTask<int?> GetTransactionIdAsync(string chargePointNameId)
        {
            try
            {
                var transaction = await db.tbTransactions
                                            .Where(t => t.ChargePointName == chargePointNameId)
                                            .AsNoTracking()
                                            .OrderByDescending(t => t.Id)
                                            .Select(s => new { s.Id, s.StartTime, s.StopTime })
                                            .FirstOrDefaultAsync();

                if (transaction != null)
                {
                    logger.LogTrace($"StopTransaction => Last transaction id={transaction.Id} / Start='{transaction.StartTime.ToString("O")}' / Stop='{transaction?.StopTime?.ToString("o")}'");
                    if (transaction.StopTime.HasValue)
                    {
                        logger.LogTrace($"StopTransaction => Last transaction (id={transaction.Id}) is already closed ");
                        transaction = null;
                    }
                }
                else
                {
                    logger.LogTrace($"StopTransaction => Found no transaction for charge point '{chargePointNameId}'");
                }

                return transaction.Id;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async ValueTask<viTransaction[]> GetAllAsync(ODataQueryOptions<tbTransaction> options)
        {
            try
            {
                var storage = db.Set<tbTransaction>();
                var query = options.ApplyTo(storage.AsNoTracking().AsQueryable(), AllowedQueryOptions.Supported);

                var cnt = await query.Cast<tbTransaction>()
                                     .OrderByDescending(o => o.Id)
                                     .ProjectTo<viTransaction>(mapper.ConfigurationProvider)
                                     .ToArrayAsync();
                return cnt;
            }
            catch (Exception ee)
            {
                logger.LogError($"TransactionsService.GetAllAsync Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(5)}");
                return null;
            }
        }

        public async ValueTask<int> GetCountAsync(ODataQueryOptions<tbTransaction> options)
        {
            var storage = db.Set<tbTransaction>();
            var query = options.ApplyTo(storage.AsNoTracking().AsQueryable(), AllowedQueryOptions.Top);

            var cnt = await query.Cast<tbTransaction>().CountAsync();
            return cnt;
        }

        public async ValueTask<Answer<tbTransaction[]>> GetMyHistoryAsync()
        {
            try
            {
                var userId = accessor.GetId();
                var res = await db.tbTransactions
                                    .AsNoTracking()
                                    .Where(x => x.CreateUser == userId)
                                    .OrderByDescending(o => o.Id)
                                    .ToArrayAsync();

                if (res == null) return new Answer<tbTransaction[]>(false, "Маълумот топилмади", null);
                return new Answer<tbTransaction[]>(true, "", res);
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository GetMyHistoryAsync Error:{ee.GetAllMessages()} ");
                return new Answer<tbTransaction[]>(false, "Тизимда хато", null);
            }
        }

        public async ValueTask<Answer<viTransactionCurrent>> GetCurrentAsync()
        {
            var userId = accessor.GetId();
            var tran = await db.tbTransactions
                                   .AsNoTracking()
                                   .OrderByDescending(x => x.StartTime)
                                   .FirstOrDefaultAsync(x => x.CreateUser == userId && x.StartResult == "Accepted" && x.StopTime == null);
            if (tran == null)
                return new Answer<viTransactionCurrent>(false, "", null);

            var viTran = new viTransactionCurrent()
            {
                ChargePointName = tran.ChargePointName,
                ConnectorId = tran.ConnectorId,
                Id = tran.Id,
            };

            return new Answer<viTransactionCurrent>(true, "", viTran);
        }

        public viIdValue CalcCarInfoAvg(int transactionId)
        {

            try
            {
                var sql = $"select max(soc) - min(soc) csoc from tb_meter_values where transaction_id ={transactionId}";
                var csoc = db.GetDbConnection().QuerySingleOrDefault<double?>(sql);

                if (csoc != null && csoc <= 0)
                {
                    logger.LogError($"Repository CalcCarInfoAvg transactionId:{transactionId} csoc:{csoc} буш чикди");
                    return null;
                }

                var tran = db.tbTransactions.AsNoTracking()
                                            .Select(s => new viTransactionCarInfo
                                            {
                                                Id = s.Id,
                                                StartTagId = s.StartTagId,
                                                MeterStop = s.MeterStop,
                                                MeterStart = s.MeterStart,
                                                StartTime = s.StartTime,
                                                StopTime = s.StopTime,
                                            })
                                            .FirstOrDefault(x => x.Id == transactionId);

                if (tran == null)
                {
                    logger.LogError($"Repository CalcCarInfoAvg transactionId:{transactionId} tran буш чикди");
                    return null;
                }


                var mySoc = (tran.MeterStop - tran.MeterStart) * 100 / csoc;

                var time = (tran.StopTime - tran.StartTime).Value.TotalSeconds;
                if (time <= 0)
                {
                    logger.LogError($"Repository CalcCarInfoAvg transactionId:{transactionId} time:{time} буш чикди");
                    return null;
                }

                var myTime = time * 100 / csoc / 3600; // Минутга утказиб куйамиз прогрешность камрок булиши учун

                var userId = db.tbChargeTags.AsNoTracking()
                                                  .Where(x => x.TagId == tran.StartTagId)
                                                  .Select(s => s.ParentTagId)
                                                  .FirstOrDefault();

                if (string.IsNullOrWhiteSpace(userId))
                {
                    logger.LogError($"Repository CalcCarInfoAvg transactionId:{transactionId} tran.StartTagId:{tran.StartTagId} userId буш чикди");
                    return null;
                }

                var myCars = db.tbCars.Where(x => x.DriverId == Guid.Parse(userId)).ToList();

                if (myCars.Count != 0)
                {
                    if (myCars.Count == 1 && myCars[0].EVBatteryCapacity > mySoc - 5 && myCars[0].EVBatteryCapacity < mySoc + 5)
                    {
                        return new viIdValue { Id = mySoc.ToStr(), Value = myTime.ToStr() };
                    }

                    if (myCars.Count > 1 && myCars.Any(x => x.EVBatteryCapacity > mySoc - 5 && x.EVBatteryCapacity < mySoc + 5))
                    {
                        return new viIdValue { Id = mySoc.ToStr(), Value = myTime.ToStr() };
                    }
                }

                var car = new tbCar
                {
                    CreateDate = DateTime.Now,
                    CreateUser = Guid.Parse(userId),
                    DriverId = Guid.Parse(userId),
                    EVBatteryCapacity = Convert.ToInt32(mySoc),
                    ChargingPerMinute = myTime.ValueOrDefault(),
                    Status = 1
                };

                db.tbCars.Add(car);
                db.SaveChanges();

                return new viIdValue { Id = mySoc.ToStr(), Value = myTime.ToStr() };
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository CalcCarInfoAvg Error:{ee.GetAllMessages()} ");
                return null;
            }
        }
    }
}
