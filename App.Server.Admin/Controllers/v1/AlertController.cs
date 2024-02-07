using App.Database.Models;
using App.Models;
using App.Repository.Services.v1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Swashbuckle.AspNetCore.Annotations;

namespace App.Server.Admin.Controllers.v1
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Станциядан чикан хатолар")]
    public class AlertController : ControllerBase
    {
        private readonly IAlertService service;
        public AlertController(IAlertService service) => this.service = service;


        [EnableQuery]
        [ODataAttributeRouting]
        [HttpGet]
        public ValueTask<tbAlert[]> GetAllAsync(ODataQueryOptions<tbAlert> options)
        {
            return service.GetAllAsync(options);
        }

        [HttpGet("Count")]
        public ValueTask<int> GetCountAsync(ODataQueryOptions<tbAlert> options)
        {
            return service.GetCountAsync(options);
        }

        [HttpGet("GetLast")]
        public ValueTask<Answer<tbAlert[]>> GetLastAsync()
        {
            return service.GetLastAsync();
        }
    }
}
