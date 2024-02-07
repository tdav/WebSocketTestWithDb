using App.Database;
using App.Database.Models;
using App.Models;
using App.Repository.Extensions;
using App.Repository.Models;
using App.Utils;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace App.Repository.Services.v1
{
    public interface IUserIdentityService
    {
        Task<Answer<TokenModel>> Login(viUserLogin model);
        Task<Answer<GetMeResponse>> GetMeAsync();
        Task<AnswerBasic> DriverRegister(viRegisterDriverUser model);
        Task<AnswerBasic> SystemUserRegister(viUser model);
        Task<AnswerBasic> SystemAdminRegister(viUser model);

        Task<AnswerBasic> UpdateProfile(viUserUpdateRequest model);

        Task<Answer<TokenModel>> RefreshToken(RefreshTokenModel tokenModel);
        Task<AnswerBasic> Revoke(string username);
        Task<AnswerBasic> RevokeAll();

        Task<AnswerBasic> ChangePassword(viChangePasswordModel value);
        Task<AnswerBasic> AdminChangePassword(viChangePasswordSmModel value);
        Task<AnswerBasic> AdminChangeStatus(viIdValue vi);


        ValueTask<viUser[]> GetQueryableAsync(ODataQueryOptions<tbUser> options);
        ValueTask<int> GetCountAsync(ODataQueryOptions<tbUser> options);

        ValueTask<viUser[]> GetDriversQueryableAsync(ODataQueryOptions<tbUser> options);
        ValueTask<int> GetDriversCountAsync(ODataQueryOptions<tbUser> options);
    }

    public class UserIdentityService : IUserIdentityService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly UserManager<tbUser> userManager;
        private readonly ILogger<UserIdentityService> logger;
        private readonly IMapper mapper;
        private readonly JwtVars vars;
        private readonly MyDbContext db;

        public UserIdentityService(UserManager<tbUser> userManager, IOptions<JwtVars> options, IOcppHttpContextAccessorExtensions accessor,
            IMapper mapper, ILogger<UserIdentityService> logger, MyDbContext db)
        {
            vars = options.Value;

            this.userManager = userManager;
            this.accessor = accessor;
            this.logger = logger;
            this.mapper = mapper;
            this.db = db;
        }

        public async Task<Answer<TokenModel>> Login(viUserLogin model)
        {
            var ip = accessor.GetUserIp();

            try
            {
                var user = await userManager.FindByNameAsync(model.PhoneNumber);
                if (user == null) return new Answer<TokenModel>(false, "Фойдаланувчи топилмади", null);

                if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
                {
                    var userRoles = await userManager.GetRolesAsync(user);

                    var accesses = string.Join(',', userRoles);

                    var authClaims = new List<Claim>
                    {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(ClaimTypes.Sid, user.Id.ToStr()),
                        new Claim(ClaimTypes.Name, $"{user.Surname} {user.Name} {user.Patronymic}"),
                        new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                    };

                    foreach (var userRole in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                    }

                    var token = CreateToken(authClaims);

                    var res = new TokenModel
                    {
                        Id = user.Id.ToString(),
                        UserInfo = $"{user.Surname} {user.Name} {user.Patronymic}",
                        Surname = user.Surname,
                        Name = user.Name,
                        Patronymic = user.Patronymic,
                        Accesses = accesses,
                        Token = new JwtSecurityTokenHandler().WriteToken(token),
                    };


                    return new Answer<TokenModel>(true, "", res);
                }

                return new Answer<TokenModel>(false, "Парол нотугри", null);
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.Login Ip:{ip} Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)}");
                return new Answer<TokenModel>(false, "Тизимда хато", null);
            }
        }

        public async Task<Answer<GetMeResponse>> GetMeAsync()
        {
            try
            {
                Guid userId = accessor.GetId();
                if (userId == Guid.Empty)
                    return new Answer<GetMeResponse>(false, "", null);

                var user = await userManager.FindByIdAsync(userId.ToString());
                if (user == null)
                    return new Answer<GetMeResponse>(false, "", null);

                var userRoles = await userManager.GetRolesAsync(user);

                var accesses = string.Join(',', userRoles);

                var res = new GetMeResponse
                {
                    Id = user.Id.ToString(),
                    UserInfo = $"{user.Surname} {user.Name} {user.Patronymic}",
                    Accesses = accesses
                };

                return new Answer<GetMeResponse>(true, "", res);
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.GetMeAsync Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new Answer<GetMeResponse>(false, "Тизимда хато", null);
            }
        }

        public async Task<AnswerBasic> DriverRegister(viRegisterDriverUser model)
        {
            try
            {
                tbUser user = await userManager?.FindByNameAsync(model.PhoneNumber);

                if (user == null)
                {
                    user = new tbUser()
                    {
                        Surname = "",
                        Name = "",
                        Patronymic = "",
                        Email = "",
                        Verified = false,
                        UserName = model.PhoneNumber,
                        PhoneNumber = model.PhoneNumber,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        CreateDate = DateTime.Now,
                        EmailConfirmed = false,
                        Status = 1
                    };

                    var result = await userManager.CreateAsync(user, model.Password);

                    if (!result.Succeeded)
                    {
                        var ss = "";
                        foreach (var it in result.Errors)
                        {
                            ss = ss + it.Description + Environment.NewLine;
                        }

                        return new AnswerBasic(false, ss);
                    }

                    await userManager.AddToRoleAsync(user, "Водители");


                    await db.SaveChangesAsync();
                }


                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.DriverRegister Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }


        public async Task<AnswerBasic> SystemUserRegister(viUser model)
        {
            try
            {
                if (!accessor.IsRoleAdmin()) return new AnswerBasic(false, "Ваколат кам.");

                var userExists = await userManager.FindByNameAsync(model.UserName);
                if (userExists != null)
                    return new AnswerBasic(false, "User already exists!");

                var user = new tbUser()
                {
                    Surname = model.Surname,
                    Name = model.Name,
                    Patronymic = model.Patronymic,
                    Email = model.Email,
                    Verified = false,

                    PhoneNumber = model.PhoneNumber,
                    UserName = model.PhoneNumber,

                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreateDate = DateTime.Now,
                    EmailConfirmed = false,
                    Status = 1
                };

                var result = await userManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    var ss = "";
                    foreach (var it in result.Errors)
                        ss = ss + it.Description + Environment.NewLine;

                    return new AnswerBasic(false, ss);
                }

                await userManager.AddToRoleAsync(user, "Пользователь системы");


                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.SystemUserRegister Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async Task<AnswerBasic> SystemAdminRegister(viUser model)
        {
            try
            {
                if (!accessor.IsRoleAdmin()) return new AnswerBasic(false, "Ваколат кам.");

                var userExists = await userManager.FindByNameAsync(model.UserName);
                if (userExists != null)
                    return new AnswerBasic(false, "User already exists!");


                tbUser user = new()
                {
                    Surname = model.Surname,
                    Name = model.Name,
                    Patronymic = model.Patronymic,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Verified = false,

                    UserName = model.PhoneNumber,

                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreateDate = DateTime.Now,
                    EmailConfirmed = false,
                    Status = 1
                };

                var result = await userManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    var ss = "";
                    foreach (var it in result.Errors)
                        ss = ss + it.Description + Environment.NewLine;
                    return new AnswerBasic(false, ss);
                }

                await userManager.AddToRoleAsync(user, "Администратор");


                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.SystemAdminRegister Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async Task<AnswerBasic> ChangePassword(viChangePasswordModel value)
        {
            try
            {
                var u = accessor.GetId();

                if (u == Guid.Empty) return new AnswerBasic(false, "Ваколат кам.");

                var user = await userManager.FindByIdAsync(u.ToString());
                if (user == null) return new AnswerBasic(false, "Invalid user name");

                var res = await userManager.ChangePasswordAsync(user, value.oldPassword, value.newPassword);
                if (res.Succeeded)
                    return new AnswerBasic(true, "");
                else
                    return new AnswerBasic(false, "Тизимда хато");
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.UserIdentityService Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async Task<AnswerBasic> AdminChangePassword(viChangePasswordSmModel value)
        {
            try
            {
                if (!accessor.IsRoleAdmin()) return new AnswerBasic(false, "Ваколат кам.");

                var user = await userManager.FindByIdAsync(value.userId);
                if (user == null) return new AnswerBasic(false, "Invalid user name");

                string token = await userManager.GeneratePasswordResetTokenAsync(user);

                var res = await userManager.ResetPasswordAsync(user, token, value.newPassword);
                if (res.Succeeded)
                    return new AnswerBasic(true, "");
                else
                {
                    var ss = string.Join(", ", res.Errors.Select(x => x.Description).ToArray());
                    return new AnswerBasic(false, ss);
                }
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.AdminChangePassword Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async Task<AnswerBasic> AdminChangeStatus(viIdValue vi)
        {
            try
            {
                if (!accessor.IsRoleAdmin()) return new AnswerBasic(false, "Ваколат кам.");

                var user = await userManager.FindByIdAsync(vi.Id);
                if (user == null) return new AnswerBasic(false, "Invalid user name");

                var res = await userManager.SetLockoutEnabledAsync(user, vi.Value == "enable");

                if (res.Succeeded)
                    return new AnswerBasic(true, "");
                else
                    return new AnswerBasic(false, "Тизимда хато");
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.AdminChangeStatus Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async Task<Answer<TokenModel>> RefreshToken(RefreshTokenModel tokenModel)
        {
            try
            {
                if (tokenModel is null)
                {
                    return new Answer<TokenModel>(false, "Invalid client request", null);
                }

                string accessToken = tokenModel.Token;
                string refreshToken = tokenModel.RefreshToken;

                var principal = GetPrincipalFromExpiredToken(accessToken);
                if (principal == null)
                {
                    return new Answer<TokenModel>(false, "Invalid access token or refresh token", null);
                }

                string guid = principal?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Sid)?.Value;

                var user = await userManager.FindByIdAsync(guid);

                if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                {
                    return new Answer<TokenModel>(false, "Invalid access token or refresh token", null);
                }


                var userRoles = await userManager.GetRolesAsync(user);
                var accesses = string.Join(',', userRoles);

                var authClaims = new List<Claim>{
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Sid, user.Id.ToStr()),
                    new Claim(ClaimTypes.Name, $"{user.Surname} {user.Name} {user.Patronymic}"),
                    new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }


                var newAccessToken = CreateToken(authClaims);
                var newRefreshToken = GenerateRefreshToken();

                user.RefreshToken = newRefreshToken;
                await userManager.UpdateAsync(user);

                return new Answer<TokenModel>(true, "", new TokenModel
                {
                    Id = user.Id.ToString(),
                    UserInfo = $"{user.Surname} {user.Name} {user.Patronymic}",
                    Surname = user.Surname,
                    Name = user.Name,
                    Patronymic = user.Patronymic,
                    Accesses = accesses,
                    Token = new JwtSecurityTokenHandler().WriteToken(newAccessToken),
                    RefreshToken = newRefreshToken
                });
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.RefreshToken Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new Answer<TokenModel>(false, "Тизимда хато", null);
            }
        }

        public async Task<AnswerBasic> Revoke(string username)
        {
            try
            {
                var user = await userManager.FindByNameAsync(username);
                if (user == null) return new AnswerBasic(false, "Invalid user name");

                user.RefreshToken = null;
                await userManager.UpdateAsync(user);
                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.Revoke Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)} ");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        public async Task<AnswerBasic> RevokeAll()
        {
            try
            {
                var users = userManager.Users.ToList();
                foreach (var user in users)
                {
                    user.RefreshToken = null;
                    await userManager.UpdateAsync(user);
                }

                return new AnswerBasic(true, "");
            }
            catch (Exception ee)
            {
                logger.LogError($"UserIdentityService.RevokeAll Error:{ee.GetAllMessages()} Stack:{ee.GetStackTrace(10)}");
                return new AnswerBasic(false, "Тизимда хато");
            }
        }

        private JwtSecurityToken CreateToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(vars.Secret));

            var token = new JwtSecurityToken(
                issuer: vars.ValidIssuer,
                audience: vars.ValidAudience,
                expires: DateTime.Now.AddDays(vars.TokenValidityInDays),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));

            return token;
        }

        private static string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(vars.Secret)),
                ValidateLifetime = false
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            if (securityToken is not JwtSecurityToken jwtSecurityToken ||
                !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;

        }


        public async Task<AnswerBasic> UpdateProfile(viUserUpdateRequest model)
        {
            var us = await db.Users.FirstOrDefaultAsync(x => x.Id == model.Id);

            if (us == null)
                return new AnswerBasic(false, "Берилган фойдаланувчи топилмади");

            us.Surname = model.Surname;
            us.Name = model.Name;
            us.Patronymic = model.Patronymic;
            us.Email = model.Email;
            await db.SaveChangesAsync();

            return new AnswerBasic(true, "Маълумотлар сақланди");
        }


        public async ValueTask<viUser[]> GetQueryableAsync(ODataQueryOptions<tbUser> options)
        {
            var storage = db.Set<tbUser>();
            var query = options.ApplyTo(storage.AsNoTracking()
                                                .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                                                   .Where(x => x.Status != 9 &&
                                                            x.UserRoles.Any(a => a.RoleId != Guid.Parse("05e0419c-15b6-4aa5-a7ca-ed11ac7d7344")))
                                                .AsQueryable(), AllowedQueryOptions.Supported);

            var cnt = await query.Cast<tbUser>().ProjectTo<viUser>(mapper.ConfigurationProvider).ToArrayAsync();
            return cnt;
        }

        public async ValueTask<int> GetCountAsync(ODataQueryOptions<tbUser> options)
        {
            var storage = db.Set<tbUser>();
            var query = options.ApplyTo(storage.AsNoTracking()
                                                  .Where(x => x.Status != 9 &&
                                                            x.UserRoles.Any(a => a.RoleId != Guid.Parse("05e0419c-15b6-4aa5-a7ca-ed11ac7d7344")))
                                               .AsQueryable(), AllowedQueryOptions.Top);

            var cnt = await query.Cast<tbUser>().CountAsync();
            return cnt;
        }


        public async ValueTask<viUser[]> GetDriversQueryableAsync(ODataQueryOptions<tbUser> options)
        {
            var storage = db.Set<tbUser>();
            var query = options.ApplyTo(storage.AsNoTracking()
                                                .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                                                .Where(x => x.Status != 9 &&
                                                            x.UserRoles.Any(a => a.RoleId == Guid.Parse("05e0419c-15b6-4aa5-a7ca-ed11ac7d7344")))
                                                .AsQueryable(), AllowedQueryOptions.Supported);

            var cnt = await query.Cast<tbUser>().ProjectTo<viUser>(mapper.ConfigurationProvider).ToArrayAsync();
            return cnt;
        }

        public async ValueTask<int> GetDriversCountAsync(ODataQueryOptions<tbUser> options)
        {
            var storage = db.Set<tbUser>();
            var query = options.ApplyTo(storage.AsNoTracking()
                                               .Where(x => x.Status != 9 &&
                                                            x.UserRoles.Any(a => a.RoleId == Guid.Parse("05e0419c-15b6-4aa5-a7ca-ed11ac7d7344")))
                                               .AsQueryable(), AllowedQueryOptions.Top);

            var cnt = await query.Cast<tbUser>().CountAsync();
            return cnt;
        }
    }
}
