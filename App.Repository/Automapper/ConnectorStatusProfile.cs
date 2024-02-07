using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{

    public class ConnectorStatusProfile : Profile
    {
        public ConnectorStatusProfile()
        {
            CreateMap<tbConnectorStatus, viConnectorStatus>()
                 .ForMember(des => des.TransactionBegin, o => o.MapFrom(sou => sou.Transaction.StartTime))
                 .ForMember(des => des.LastStatus, o => o.MapFrom(sou => sou.Status))
                 .ForMember(des => des.LastStatusTime, o => o.MapFrom(sou => sou.StatusTime))
                 .ForMember(des => des.LastMeter, o => o.MapFrom(sou => sou.MeterKWH))
                 .ForMember(des => des.LastMeterTime, o => o.MapFrom(sou => sou.MeterValueTime))
                 .ForMember(des => des.CreateUser, o => o.MapFrom(sou => sou.DriverUserId));
        }
    }

}