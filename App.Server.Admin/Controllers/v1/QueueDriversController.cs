using App.Database.Models;
using App.Models;
using App.Repository.Models;
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
    [SwaggerTag("Очередь водители")]
    public class QueueDriversController : ControllerBase
    {
        private readonly IQueueDriverService service;
        public QueueDriversController(IQueueDriverService service)
        {
            this.service = service;
        }

        [EnableQuery]
        [ODataAttributeRouting]
        [HttpGet]
        public ValueTask<viQueueDriver[]> GetQueryableAsync(ODataQueryOptions<tbQueueDriver> options)
        {
            return service.GetQueryableAsync(options);
        }

        [HttpGet("Count")]
        public ValueTask<int> GetCountAsync(ODataQueryOptions<tbQueueDriver> options)
        {
            return service.GetCountAsync(options);
        }


        [HttpGet("Get/{id}")]
        [SwaggerOperation("ID = ChargePoint ID")]
        public ValueTask<Answer<viQueueDriver[]>> GetByChargePointAsync(int id)
        {
            return service.GetByChargePointAsync(id);
        }

        [HttpPost("Insert")]
        public ValueTask<Answer<viQueueDriverResponce>> InsertAsync(viQueueDriverReqest value)
        {
            return service.InsertAsync(value);
        }

        [HttpPost("Delete")]
        public ValueTask<AnswerBasic> DeleteAsync(viQueueDriverCancel val)
        {
            return service.DeleteAsync(val);
        }
    }
}
