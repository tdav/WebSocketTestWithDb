using App.Database.Models;
using App.Repository.Models;
using AutoMapper;

namespace App.Repository.Automapper
{
    public class ConnectorTypeProfile : Profile
    {
        public ConnectorTypeProfile()
        {
            CreateMap<spConnectorType, viConnectorType>();
        }
    }
}