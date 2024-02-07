using App.Models;
using App.Repository.Models;
using App.Repository.Services.v1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace App.Server.Admin.Controllers.v1
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Фоайдаланувчилар ваколатларини бошқариш")]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService service;

        public RolesController(IRoleService service)
        {
            this.service = service;
        }


        [HttpGet]
        public ValueTask<Answer<string[]>> GetAllRoles()
        {
            return service.GetAllRoles();
        }

        [Authorize(Roles = "Администратор")]
        [HttpGet("GetRolesByUser/{userId}")]
        public ValueTask<Answer<string[]>> GetRolesByUser(Guid userId)
        {
            return service.GetRolesByUser(userId);
        }

        [Authorize(Roles = "Администратор")]
        [HttpPost("SetRoles")]
        public ValueTask<AnswerBasic> SetRoles(viChangeRole vi)
        {
            return service.SetRoles(vi);
        }

        [Authorize(Roles = "Администратор")]
        [HttpPost("RemoveRoles")]
        public ValueTask<AnswerBasic> RemoveRoles(viChangeRole vi)
        {
            return service.RemoveRoles(vi);
        }
    }
}
