using App.Interfaces.Models;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Threading.Tasks;

namespace App.Interfaces
{
    public interface IExternalFuncPlugin
    {
        string Name { get; }
        string Description { get; }
        string Version { get; }
        void Initialize(IServiceCollection services);
        Task<FilterResult> RunAsync(Stream stream);
    }
}

//https://www.codeproject.com/Articles/5321450/ASP-NET-Core-Web-API-Plugin-Controllers-and-Servic