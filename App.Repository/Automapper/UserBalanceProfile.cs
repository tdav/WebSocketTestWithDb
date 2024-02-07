using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{
    public class UserBalanceProfile : Profile
    {
        public UserBalanceProfile()
        {
            CreateMap<tbUser, viUserBalance>();
        }
    }
}