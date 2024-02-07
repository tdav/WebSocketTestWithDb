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
    [SwaggerTag("Справочник таблицалар")]
    public class SprController : ControllerBase
    {
        [HttpGet("GetRegion")]
        public ValueTask<Answer<spRegion[]>> GetAsync([FromServices] IRegionService service)
        {
            return service.GetAllAsync();
        }

        [EnableQuery]
        [ODataAttributeRouting]
        [HttpGet("GetDistrict")]
        public ValueTask<spDistrict[]> GetAsync([FromServices] IDistrictService service, ODataQueryOptions<spDistrict> options)
        {
            return service.GetAllAsync(options);
        }

        [HttpGet("GetUnit")]
        public ValueTask<Answer<spUnit[]>> GetAsync([FromServices] IUnitService service)
        {
            return service.GetAllAsync();
        }

        [HttpGet("GetStatus")]
        public ValueTask<Answer<spStatus[]>> GetAsync([FromServices] IStatusService service)
        {
            return service.GetAllAsync();
        }
    }
}
