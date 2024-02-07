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
    [SwaggerTag("Трансакции зарядная станция")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsService service;

        public TransactionsController(ITransactionsService service)
        {
            this.service = service;
        }

        [EnableQuery]
        [ODataAttributeRouting]
        [HttpGet]
        public ValueTask<viTransaction[]> GetAllAsync(ODataQueryOptions<tbTransaction> options)
        {
            return service.GetAllAsync(options);
        }

        [HttpGet("Count")]
        public ValueTask<int> GetCountAsync(ODataQueryOptions<tbTransaction> options)
        {
            return service.GetCountAsync(options);
        }

        [HttpGet("Current")]
        public ValueTask<Answer<viTransactionCurrent>> GetCurrentAsync()
        {
            return service.GetCurrentAsync();
        }

        [HttpGet("MyHistory")]
        public ValueTask<Answer<tbTransaction[]>> GetMyHistoryAsync()
        {
            return service.GetMyHistoryAsync();
        }

        [HttpPost("TestMyStat/{id}")]
        public viIdValue TestMyStat(int id)
        {
            return service.CalcCarInfoAvg(id);
        }
    }
}
