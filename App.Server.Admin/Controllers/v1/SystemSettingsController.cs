using App.Database.Models;
using App.Models;
using App.Repository.Services.v1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace App.Server.Admin.Controllers.v1
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Настройки системы")]
    public class SystemSettingsController : ControllerBase, ISystemSettingsService
    {
        private readonly ISystemSettingsService service;

        public SystemSettingsController(ISystemSettingsService service)
        {
            this.service = service;
        }

        [HttpGet("{id}")]
        public ValueTask<Answer<tbSystemSetting>> GetByIdAsync(int id)
        {
            return service.GetByIdAsync(id);
        }

        [HttpPost("Insert")]
        public ValueTask<AnswerBasic> InsertAsync(tbSystemSetting value)
        {
            return service.InsertAsync(value);
        }

        [HttpPost("Update")]
        public ValueTask<AnswerBasic> UpdateAsync(tbSystemSetting value)
        {
            return service.UpdateAsync(value);
        }

        [HttpDelete]
        public ValueTask<AnswerBasic> DeleteAsync(int id)
        {
            return service.DeleteAsync(id);
        }

    }
}
