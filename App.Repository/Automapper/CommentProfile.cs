using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<tbComment, viComment>()
                 .ForMember(des => des.UserInfo, o => o.MapFrom(sou => $"{sou.User.Surname} {sou.User.Name} {sou.User.Patronymic}"));
        }
    }
}