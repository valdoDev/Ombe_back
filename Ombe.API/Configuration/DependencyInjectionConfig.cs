using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Ombe.Business.Interfaces;
using Ombe.Business.Notifications;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Ombe.API.Configuration
{
    public static class DependencyInjectionConfig
    {

        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<INotifier, Notifier>();

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
