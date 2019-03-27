using Blct.Concretes;
using Blct.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Blct.WebApi
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // Add all dependecies/services here
            services.AddTransient<IArrayOperations, ArrayOperationsComponent>();
                       
            return services;
        }
    }
}