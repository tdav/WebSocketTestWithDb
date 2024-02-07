using Microsoft.Extensions.DependencyInjection;

namespace App.Interfaces
{
    public interface IExternalApiPlugin
    {
        string Name { get; }
        string Description { get; }
        string Version { get; }
        void Initialize(IServiceCollection services);
    }
}

//https://www.codeproject.com/Articles/5321450/ASP-NET-Core-Web-API-Plugin-Controllers-and-Servic