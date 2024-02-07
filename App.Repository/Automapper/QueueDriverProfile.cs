using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{
    public class QueueDriverProfile : Profile
    {
        public QueueDriverProfile()
        {
            CreateMap<tbQueueDriver, viQueueDriver>()
                 .ForMember(des => des.DriverUserId, o => o.MapFrom(sou => sou.CreateUser));
        }
    }
}