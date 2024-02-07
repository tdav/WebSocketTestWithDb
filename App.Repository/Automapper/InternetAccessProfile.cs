using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{
    public class InternetAccessProfile : Profile
    {
        public InternetAccessProfile()
        {
            CreateMap<tbInternetAccess, viInternetAccess>()
                 .ForMember(des => des.ChargePoint, o => o.MapFrom(sou => sou.ChargePoint.Name))
                 .ForMember(des => des.InternetAccessType, o => o.MapFrom(sou => sou.InternetAccessType.Name));
        }
    }
}