using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace TestMapsterCodeGen.Client;

public static class ServiceExtensions
{
    public static IServiceCollection AddAllMappersInAssembly(this IServiceCollection services, Assembly assembly, string @namespace)
    {
        foreach (var mapperClass in assembly.GetTypes().Where(x => x.IsClass && x.Namespace == @namespace))
        {
            var mapperInterface = mapperClass.GetInterfaces().FirstOrDefault(y => y.Name == $"I{mapperClass.Name}");
            if (mapperInterface != null)
            {
                services.AddSingleton(mapperInterface, mapperClass);
            }
        }

        return services;
    }
}