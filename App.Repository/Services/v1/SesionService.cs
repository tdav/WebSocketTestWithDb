using App.Database;
using App.Database.Models;
using App.Repository.Extensions;
using App.Utils;
using Microsoft.Extensions.Logging;

namespace App.Repository.Services.v1
{
    public interface ISesionService
    {
        ValueTask AddAsync(Guid userId, string roles, string phoneNumber, string deviceId);
    }

    public class SesionService : ISesionService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly ILogger<SesionService> logger;
        private readonly MyDbContext db;

        public SesionService(ILogger<SesionService> logger, MyDbContext db, IOcppHttpContextAccessorExtensions accessor)
        {
            this.db = db;
            this.logger = logger;
            this.accessor = accessor;
        }

        public async ValueTask AddAsync(Guid userId, string roles, string phoneNumber, string deviceId)
        {
            try
            {
                var sesion = new tbSesion();
                sesion.CreateDate = DateTime.Now;
                sesion.DeviceId = deviceId;
                sesion.IpAdress = accessor.GetUserIp();
                sesion.PhoneNumber = phoneNumber;
                sesion.UserId = accessor.GetId();
                sesion.Roles = roles;
                sesion.Сountry = "";
                await db.tbSesions.AddAsync(sesion);
                await db.SaveChangesAsync();
            }
            catch (Exception ee)
            {
                logger.LogError($"SesionService GetAsync Error:{ee.GetAllMessages()} ");
            }
        }
    }
}
