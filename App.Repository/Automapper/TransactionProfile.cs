using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<tbTransaction, viTransaction>()
                 .ForMember(des => des.StartTagId, o => o.MapFrom(sou => sou.StartTagId == "000000000" ? "Ручной запуск" : sou.StartTagId));
        }
    }
}