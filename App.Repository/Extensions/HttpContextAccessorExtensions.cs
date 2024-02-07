using App.Utils;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace App.Repository.Extensions
{
    public interface IOcppHttpContextAccessorExtensions
    {
        bool IsRoleAdmin();
        bool InRole(string role);
        Guid GetId();
        string GetAccess();
        string GetUserFullName();
        string GetMobilePhone();
        string GetUserIp();
        int GetUserType();
    }

    public class OcppHttpContextAccessorExtensions : IOcppHttpContextAccessorExtensions
    {
        private readonly IHttpContextAccessor accessor;

        public OcppHttpContextAccessorExtensions(IHttpContextAccessor accessor)
        {
            this.accessor = accessor;
        }

        public bool IsRoleAdmin()
        {
            return accessor.HttpContext?.User.IsInRole("Администратор") ?? false;
        }

        public bool InRole(string name)
        {
            return accessor.HttpContext?.User.IsInRole(name) ?? false;
        }

        public Guid GetId()
        {
            var r = accessor.HttpContext?.User?.FindFirst(ClaimTypes.Sid);
            return r == null ? Guid.Empty : r.Value.ToGuid();
        }

        public string GetAccess()
        {
            var role = accessor.HttpContext?.User.FindFirst(ClaimTypes.Role);
            return role?.Value ?? "";
        }

        public string GetUserFullName()
        {
            var role = accessor.HttpContext?.User.FindFirst(ClaimTypes.Name);
            return role?.Value ?? "";
        }

        public string GetMobilePhone()
        {
            var role = accessor.HttpContext?.User.FindFirst(ClaimTypes.MobilePhone);
            return role?.Value ?? "";
        }

        public string GetUserIp()
        {
            //https://10xers.medium.com/how-to-get-the-clients-ip-address-in-net-core-when-behind-an-nginx-reverse-proxy-a128bf2a8450

            var clientIp = accessor.HttpContext?.Request.Headers["X-Real-IP"].ToString();


            if (string.IsNullOrEmpty(clientIp))
            {
                clientIp = accessor.HttpContext?.Connection.RemoteIpAddress.ToString();
            }

            return clientIp;

            return accessor.HttpContext?.Connection?.RemoteIpAddress?.ToString() ?? "";
        }

        public int GetUserType()
        {
            /*
              
            1 - Driver
            2 - Web

             */

            var r = accessor.HttpContext?.User?.FindFirst("UserTypeId");
            return r == null ? -1 : Convert.ToInt32(r.Value);
        }
    }
}
