using App.Database;
using App.Database.Models;
using App.Models;
using App.Repository.Extensions;
using App.Repository.Models;
using App.Utils;
using App.Utils.Serializable;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreSecondLevelCacheInterceptor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface ICommentsService
    {
        ValueTask<Answer<viComment[]>> GetAllAsync(int id);
        ValueTask<AnswerBasic> InsertAsync(tbComment value);
        ValueTask<AnswerBasic> UpdateAsync(tbComment value);
        ValueTask<AnswerBasic> DeleteAsync(int id);
    }


    public class CommentsService : ICommentsService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly ILogger<CommentsService> logger;
        private readonly MyDbContext db;
        private readonly IMapper mapper;

        public CommentsService(ILogger<CommentsService> logger, MyDbContext db, IMapper mapper, IOcppHttpContextAccessorExtensions accessor)
        {
            this.db = db;
            this.logger = logger;
            this.mapper = mapper;
            this.accessor = accessor;
        }

        public async ValueTask<Answer<viComment[]>> GetAllAsync(int id)
        {
            try
            {
                var res = await db.tbComments.AsNoTracking()
                                    .Include(x => x.User)
                                    .Where(x => x.Status == 1 && x.ChargePointId == id)
                                    .OrderByDescending(x => x.Id)
                                    .Take(100)
                                    .Cacheable()
                                    .ProjectTo<viComment>(mapper.ConfigurationProvider)
                                    .ToArrayAsync();

                if (res == null || res?.Length == 0) return new Answer<viComment[]>(false, "Маълумот топилмади", null);
                return new Answer<viComment[]>(true, "", res);
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbComment GetAllAsync Error:{ee.GetAllMessages()} ");
                return new Answer<viComment[]>(false, "Тизимда хато", null);
            }
        }

        public async ValueTask<AnswerBasic> InsertAsync(tbComment value)
        {
            try
            {
                value.CreateDate = DateTime.Now;
                value.CreateUser = accessor.GetId();
                value.Status = 0;
                value.UserId = accessor.GetId();
                await db.tbComments.AddAsync(value);
                await db.SaveChangesAsync();
                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbComment InsertAsync Model:{value.ToJson()} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async ValueTask<AnswerBasic> UpdateAsync(tbComment value)
        {
            try
            {
                var cc = await db.tbComments.FirstOrDefaultAsync(x => x.Id == value.Id);

                if (cc == null) return new AnswerBasic(false, "Маълумот топилмади");

                cc.Status = value.Status;
                cc.MesText = value.MesText;
                cc.Rating = value.Rating;
                cc.UpdateDate = DateTime.Now;
                cc.UpdateUser = accessor.GetId();

                await db.SaveChangesAsync();
                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbComment Update Model:{value.ToJson()} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async ValueTask<AnswerBasic> DeleteAsync(int id)
        {
            try
            {
                var it = await db.tbComments.FirstOrDefaultAsync(x => x.Id == id);
                it.Status = 0;
                await db.SaveChangesAsync();
                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbComment Delete Id:{id} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

    }
}
