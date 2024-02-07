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
    [SwaggerTag("Управление пользователями")]
    public class UserController : ControllerBase
    {
        private readonly IUserIdentityService service;

        public UserController(IUserIdentityService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        [HttpPost("DriverRegister")]
        public Task<AnswerBasic> DriverRegister(viRegisterDriverUser model)
        {
            return service.DriverRegister(model);
        }

        [Authorize(Roles = "Администратор")]
        [HttpPost("SystemAdminRegister")]
        public Task<AnswerBasic> SystemAdminRegister(viUser model)
        {
            return service.SystemAdminRegister(model);
        }

        [Authorize(Roles = "Администратор")]
        [HttpPost("SystemUserRegister")]
        public Task<AnswerBasic> SystemUserRegister(viUser model)
        {
            return service.SystemUserRegister(model);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public Task<Answer<TokenModel>> Login(viUserLogin model)
        {
            return service.Login(model);
        }

        [AllowAnonymous]
        [HttpGet("Me")]
        public Task<Answer<GetMeResponse>> GetMeAsync()
        {
            return service.GetMeAsync();
        }

        [HttpPost("RefreshToken")]
        public Task<Answer<TokenModel>> RefreshToken(RefreshTokenModel tokenModel)
        {
            return service.RefreshToken(tokenModel);
        }

        [HttpPost("UpdateProfile")]
        public Task<AnswerBasic> UpdateProfile(viUserUpdateRequest model)
        {
            return service.UpdateProfile(model);
        }



        [HttpPost("Revoke")]
        public Task<AnswerBasic> Revoke(string username)
        {
            return service.Revoke(username);
        }

        [HttpPost("RevokeAll")]
        public Task<AnswerBasic> RevokeAll()
        {
            return service.RevokeAll();
        }

        [HttpPost("ChangePassword")]
        public Task<AnswerBasic> ChangePassword(viChangePasswordModel value)
        {
            return service.ChangePassword(value);
        }

        [Authorize(Roles = "Администратор")]
        [HttpPost("AdminChangePassword")]
        public Task<AnswerBasic> AdminChangePassword(viChangePasswordSmModel value)
        {
            return service.AdminChangePassword(value);
        }

        [Authorize(Roles = "Администратор")]
        [HttpPost("AdminChangeStatus")]
        public Task<AnswerBasic> AdminChangeStatus(viIdValue vi)
        {
            return service.AdminChangeStatus(vi);
        }

        [EnableQuery]
        [ODataAttributeRouting]
        [HttpGet]
        public ValueTask<viUser[]> GetQueryableAsync(ODataQueryOptions<tbUser> options)
        {
            return service.GetQueryableAsync(options);
        }

        [HttpGet("Count")]
        public ValueTask<int> GetCountAsync(ODataQueryOptions<tbUser> options)
        {
            return service.GetCountAsync(options);
        }


        [EnableQuery]
        [ODataAttributeRouting]
        [HttpGet("GetDriversList")]
        public ValueTask<viUser[]> GetDriversQueryableAsync(ODataQueryOptions<tbUser> options)
        {
            return service.GetDriversQueryableAsync(options);
        }

        [HttpGet("GetDriversCount")]
        public ValueTask<int> GetDriversCountAsync(ODataQueryOptions<tbUser> options)
        {
            return service.GetDriversCountAsync(options);
        }

    }
}
