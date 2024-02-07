using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;

namespace App.Server.Report.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DebugRoutesController : ControllerBase
    {
        private readonly IEnumerable<EndpointDataSource> _endpointSources;

        public DebugRoutesController(IEnumerable<EndpointDataSource> endpointSources)
        {
            _endpointSources = endpointSources;
        }

        [HttpGet]
        public ActionResult ListAllEndpoints()
        {
            var endpoints = _endpointSources.SelectMany(es => es.Endpoints).OfType<RouteEndpoint>();
            var output = endpoints.Select(
                e =>
                {
                    var controller = e.Metadata.OfType<ControllerActionDescriptor>().FirstOrDefault();
                    var action = controller != null
                        ? $"{controller.ControllerName}.{controller.ActionName}"
                        : null;
                    var controllerMethod = controller != null
                        ? $"{controller.ControllerTypeInfo.FullName}:{controller.MethodInfo.Name}"
                        : null;
                    return new
                    {
                        Method = e.Metadata.OfType<HttpMethodMetadata>().FirstOrDefault()?.HttpMethods?[0],
                        Route = $"/{e.RoutePattern.RawText.TrimStart('/')}",
                        Action = action,
                        ControllerMethod = controllerMethod
                    };
                }
            );

            return new JsonResult(output);
        }
    }
}
