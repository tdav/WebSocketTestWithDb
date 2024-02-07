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
    public interface IFavoriteService
    {
        ValueTask<Answer<int[]>> GetAllAsync();
        ValueTask<AnswerBasic> InsertAsync(int value);
        ValueTask<AnswerBasic> DeleteAsync(int id);
    }


    public class FavoriteService : IFavoriteService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly ILogger<FavoriteService> logger;
        private readonly MyDbContext db;

        public FavoriteService(ILogger<FavoriteService> logger, MyDbContext db, IOcppHttpContextAccessorExtensions accessor)
        {
            this.db = db;
            this.logger = logger;
            this.accessor = accessor;
        }

        public async ValueTask<Answer<int[]>> GetAllAsync()
        {
            try
            {

                var res = await db.tbFavorites.AsNoTracking()
                                    .Where(x => x.Status == 1 && x.CreateUser == accessor.GetId())
                                    .Select(s => s.Id)
                                    .ToArrayAsync();

                if (res == null || res?.Length == 0)
                    return new Answer<int[]>(false, "Маълумот топилмади", null);

                return new Answer<int[]>(true, "", res);
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbFavorite GetAllAsync Error:{ee.GetAllMessages()} ");
                return new Answer<int[]>(false, "Тизимда хато", null);
            }
        }


        public async ValueTask<AnswerBasic> InsertAsync(int value)
        {
            try
            {
                var userId = accessor.GetId();

                if (await db.tbFavorites.AnyAsync(s => s.ChargePointId == value && s.CreateUser == userId))
                    return new AnswerBasic(true, "");

                var fv = new tbFavorite()
                {
                    ChargePointId = value,
                    Status = 1,
                    CreateDate = DateTime.Now,
                    CreateUser = userId
                };

                await db.tbFavorites.AddAsync(fv);
                await db.SaveChangesAsync();
                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbFavorite InsertAsync Model:{value.ToJson()} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }


        public async ValueTask<AnswerBasic> DeleteAsync(int id)
        {
            try
            {
                var userId = accessor.GetId();
                var it = await db.tbFavorites.FirstOrDefaultAsync(x => x.Id == id && x.CreateUser == userId);

                if (it == null)
                    return new AnswerBasic(true, "");

                db.tbFavorites.Remove(it);
                await db.SaveChangesAsync();
                return new AnswerBasic(true, "");

            }
            catch (Exception ee)
            {
                logger.LogError($"Repository tbFavorite Delete Id:{id} Error:{ee.GetAllMessages()} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

    }
}
