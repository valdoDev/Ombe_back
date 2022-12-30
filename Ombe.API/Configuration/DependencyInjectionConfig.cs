using Microsoft.Extensions.DependencyInjection;

namespace Ombe.API.Configuration
{
    public static class DependencyInjectionConfig
    {

        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            return services;
        }
    }
}
