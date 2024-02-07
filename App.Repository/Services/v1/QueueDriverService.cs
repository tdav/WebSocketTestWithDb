using App.Database;
using App.Database.Models;
using App.Models;
using App.Repository.Extensions;
using App.Repository.Models;
using App.Utils;
using App.Utils.Serializable;
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
        ValueTask<Answer<viQueueDriverResponce>> InsertAsync(viQueueDriverReqest value);
        ValueTask<AnswerBasic> DeleteAsync(viQueueDriverCancel val);

        ValueTask<int> GetCountAsync(ODataQueryOptions<tbQueueDriver> options);
        ValueTask<viQueueDriver[]> GetQueryableAsync(ODataQueryOptions<tbQueueDriver> options);


        void StartDriverTransaction(int chargePointId, Guid userId);
        void StopDriverTransaction(int chargePointId, Guid userId);
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
                                    .Where(x => x.Status == 1 && x.ChargePointId == id)
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

        public async ValueTask<Answer<viQueueDriverResponce>> InsertAsync(viQueueDriverReqest value)
        {
            try
            {
                var userId = accessor.GetId();
                var phoneNumber = accessor.GetMobilePhone();

                var driverExits = await db.tbQueueDrivers
                                          .AsNoTracking()
                                          .Where(x => x.CreateUser == userId && x.Status == 1)
                                          .Select(s => new viQueueDriverResponce
                                          {
                                              PhoneNumber = s.PhoneNumber,
                                              PlateNumber = s.PlateNumber,
                                              Status = s.Status,
                                              Name = s.ChargePoint.Name,
                                              Address = s.ChargePoint.Street,
                                              CreateDate = s.CreateDate,
                                          })
                                          .FirstOrDefaultAsync();


                if (driverExits != null)
                {
                    return new Answer<viQueueDriverResponce>(false, "Сиз бошқа станцияда навбатда бор экансиз", driverExits);
                }

                var qd = new tbQueueDriver();
                qd.ConnectorId = value.ConnectorId;
                qd.ChargePointId = value.ChargePointId;
                qd.PhoneNumber = phoneNumber;
                qd.UserInfo = accessor.GetUserFullName();
                qd.Comment = value.Comment;
                qd.BeginTime = null;
                qd.EndTime = null;
                qd.CreateDate = DateTime.Now;
                qd.CreateUser = userId;
                qd.Status = 1;

                await db.tbQueueDrivers.AddAsync(qd);
                await db.SaveChangesAsync();

                var chargePoint = await db.tbQueueDrivers
                                          .Include(i => i.ChargePoint)
                                          .AsNoTracking()
                                          .Where(x => x.ChargePointId == value.ChargePointId && x.Status == 1)
                                          .GroupBy(x => new { x.ChargePoint.Name, x.ChargePoint.Street })
                                          .Select(s => new
                                          {
                                              s.Key.Name,
                                              s.Key.Street,
                                              Count = s.Count()
                                          })
                                          .FirstOrDefaultAsync();


                var res = new viQueueDriverResponce
                {
                    PhoneNumber = phoneNumber,
                    PlateNumber = "",
                    Name = chargePoint.Name,
                    Address = chargePoint.Street,
                    Position = chargePoint.Count,
                    CreateDate = DateTime.Now,
                    Status = 1,
                };

                return new Answer<viQueueDriverResponce>(true, "", res);
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbQueueDriver InsertAsync Model:{value.ToJson()} Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(5)} ");
                return new Answer<viQueueDriverResponce>(false, "Тизимда хато", null);
            }
        }

        public async ValueTask<AnswerBasic> DeleteAsync(viQueueDriverCancel val)
        {
            try
            {
                await db.tbQueueDrivers
                        .Where(x => x.Id == val.Id && x.CreateUser == accessor.GetId())
                        .ExecuteUpdateAsync(s => s.SetProperty(u => u.Status, 0)
                                                  .SetProperty(u => u.CancelReason, val.CancelReason));

                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbQueueDriver Delete Id:{val.Id} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public void StartDriverTransaction(int chargePointId, Guid userId)
        {
            try
            {
                db.tbQueueDrivers
                        .Where(x => x.Status == 1 && x.ChargePointId == chargePointId && x.CreateUser == userId)
                        .ExecuteUpdate(s => s.SetProperty(u => u.BeginTime, DateTime.Now));
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbQueueDriver StartDriverTransactionAsync UserId:{userId} Error:{ee.GetAllMessages()} ");
            }
        }

        public void StopDriverTransaction(int chargePointId, Guid userId)
        {
            try
            {
                db.tbQueueDrivers
                        .Where(x => x.Status == 1 && x.ChargePointId == chargePointId && x.CreateUser == userId)
                        .ExecuteUpdate(s => s.SetProperty(u => u.EndTime, DateTime.Now)
                                             .SetProperty(u => u.Status, 0));
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbQueueDriver StartDriverTransactionAsync UserId:{userId} Error:{ee.GetAllMessages()} ");
            }
        }
    }
}
