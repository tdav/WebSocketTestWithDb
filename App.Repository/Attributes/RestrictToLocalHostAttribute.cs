using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace App.Repository.Attributes;

public class RestrictToLocalHostAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        IPAddress remoteIp = context.HttpContext.Connection.RemoteIpAddress;
        if (remoteIp == null || !IPAddress.IsLoopback(remoteIp))
        {
            context.Result = new UnauthorizedResult();
            return;
        }
        base.OnActionExecuting(context);
    }
}
