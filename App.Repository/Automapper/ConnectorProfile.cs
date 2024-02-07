using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{

    public class ConnectorExtProfile : Profile
    {
        public ConnectorExtProfile()
        {
            CreateMap<tbConnector, viConnectorExt>()
               .ForMember(des => des.ChargePoint, o => o.MapFrom(sou => sou.ChargePoint.ChargePointId))
               .ForMember(des => des.ConnectorType, o => o.MapFrom(sou => sou.ConnectorType));
        }
    }


    public class ConnectorSimpleProfile : Profile
    {
        public ConnectorSimpleProfile()
        {
            CreateMap<tbConnector, viConnectorSimple>()
               .ForMember(des => des.Status, o => o.MapFrom(sou => sou.Status))
               .ForMember(des => des.ConnectorType, o => o.MapFrom(sou => sou.ConnectorType.Name))
               .ForMember(des => des.Country, o => o.MapFrom(sou => sou.ConnectorType.Country))
               .ForMember(des => des.Throughput, o => o.MapFrom(sou => sou.Throughput))
               .ForMember(des => des.ConnectorImageUrl, o => o.MapFrom(sou => sou.ConnectorType.ImageUrl));
        }
    }

}