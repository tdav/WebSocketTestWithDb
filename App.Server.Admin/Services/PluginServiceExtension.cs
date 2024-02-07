using App.Interfaces;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Reflection;

namespace App.Server.Admin.Services
{
    public static class PluginServiceExtension
    {
        public static IServiceCollection LoadApiPluginsService(this IServiceCollection services)
        {
            var PluginList = from p in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory).AsEnumerable()
                             where p.EndsWith(".api.plg.dll", StringComparison.InvariantCultureIgnoreCase)
                             select p;

            foreach (var path in PluginList)
            {
                Assembly assembly = Assembly.LoadFrom(path);
                var part = new AssemblyPart(assembly);
                services.AddControllers().PartManager.ApplicationParts.Add(part);

                var atypes = assembly.GetTypes();
                var pluginClass = atypes.SingleOrDefault(t => t.GetInterface(nameof(IExternalApiPlugin)) != null);

                if (pluginClass != null)
                {
                    var initMethod = pluginClass.GetMethod(nameof(IExternalApiPlugin.Initialize), BindingFlags.Public | BindingFlags.Instance);
                    var obj = Activator.CreateInstance(pluginClass);
                    initMethod?.Invoke(obj, new object[] { services });
                }
            };

            return services;
        }

        public static IServiceCollection LoadFuncPluginsService(this IServiceCollection services)
        {
            var PluginList = from p in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory).AsEnumerable()
                             where p.EndsWith(".func.plg.dll", StringComparison.InvariantCultureIgnoreCase)
                             select p;

            foreach (var path in PluginList)
            {
                Assembly assembly = Assembly.LoadFrom(path);
                var atypes = assembly.GetTypes();
                var pluginClass = atypes.SingleOrDefault(t => t.GetInterface(nameof(IExternalFuncPlugin)) != null);

                if (pluginClass != null)
                {
                    var initMethod = pluginClass.GetMethod(nameof(IExternalFuncPlugin.Initialize), BindingFlags.Public | BindingFlags.Instance);
                    var obj = Activator.CreateInstance(pluginClass);
                    initMethod?.Invoke(obj, new object[] { services });
                }
            };

            return services;
        }
    }
}
