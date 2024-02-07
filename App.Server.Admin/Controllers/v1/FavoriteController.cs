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
    [SwaggerTag("Избранные")]
    public class FavoriteController : ControllerBase
    {
        private readonly IFavoriteService service;

        public FavoriteController(IFavoriteService service)
        {
            this.service = service;
        }

        [HttpDelete("Delete/{id}")]
        public ValueTask<AnswerBasic> DeleteAsync(int id)
        {
            return service.DeleteAsync(id);
        }


        [HttpGet("GetAll")]
        public ValueTask<Answer<int[]>> GetAllAsync()
        {
            return service.GetAllAsync();
        }

        [HttpPost("Insert/{id}")]
        public ValueTask<AnswerBasic> InsertAsync(int id)
        {
            return service.InsertAsync(id);
        }
    }
}
