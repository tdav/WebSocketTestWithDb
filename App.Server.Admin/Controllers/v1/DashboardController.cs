using App.Models;
using App.Repository.Models;
using App.Repository.Services.v1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace App.Server.Admin.Controllers.v1
{
    //[Authorize(Roles = "Администратор")]
    //[Authorize(Roles = "Пользователь системы")]
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Асосий сахифадаги диаграммлар")]
    public class DashboardController : ControllerBase, IDashboardService
    {
        private readonly IDashboardService service;

        public DashboardController(IDashboardService service)
        {
            this.service = service;
        }

        [HttpPost("Main")]
        public ValueTask<Answer<viDashboardModel>> GetAsync(viDashboardRequest vi)
        {
            return service.GetAsync(vi);
        }
    }
}
