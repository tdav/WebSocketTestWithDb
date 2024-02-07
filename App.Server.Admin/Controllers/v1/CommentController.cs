using App.Database.Models;
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
    [SwaggerTag("Хайдовчилар комментарияси")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentsService service;

        public CommentController(ICommentsService service)
        {
            this.service = service;
        }


        [Authorize(Roles = "Администратор")]
        [HttpDelete("Delete/{id}")]
        public ValueTask<AnswerBasic> DeleteAsync(int id)
        {
            return service.DeleteAsync(id);
        }

        [HttpGet("GetAll/{id}")]
        [SwaggerOperation("ID = ChargePointId")]
        public ValueTask<Answer<viComment[]>> GetAllAsync(int id)
        {
            return service.GetAllAsync(id);
        }

        [HttpPost("Insert")]
        public ValueTask<AnswerBasic> InsertAsync(tbComment value)
        {
            return service.InsertAsync(value);
        }

        [Authorize(Roles = "Администратор")]
        [HttpPost("Update")]
        public ValueTask<AnswerBasic> UpdateAsync(tbComment value)
        {
            return service.UpdateAsync(value);
        }
    }
}
