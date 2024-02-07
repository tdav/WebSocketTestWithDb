using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<tbUser, viUser>()
            .ForMember(des => des.Password, o => o.MapFrom(sou => ""))
            .ForMember(des => des.UserType, o => o.MapFrom(sou => sou.UserRoles.Select(s => s.Role.Name).FirstOrDefault()));
        }
    }
}