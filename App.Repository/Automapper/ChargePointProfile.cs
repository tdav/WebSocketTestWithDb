using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{
    public class ChargePointProfile : Profile
    {
        public ChargePointProfile()
        {
            CreateMap<tbChargePoint, viChargePointExt>()
               .ForMember(des => des.Region, o => o.MapFrom(sou => sou.Region.NameUz))
               .ForMember(des => des.District, o => o.MapFrom(sou => sou.District.NameUz))
               .ForMember(des => des.Connectors, o => o.MapFrom(sou => sou.Connectors));
        }
    }
}