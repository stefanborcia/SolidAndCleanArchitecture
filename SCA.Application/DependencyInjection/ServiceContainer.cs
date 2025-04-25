using Microsoft.Extensions.DependencyInjection;
using SCA.Application.MappingImplementation;
using SCA.Application.MappingInterface;
using SCA.Application.ServiceImplementation;
using SCA.Application.ServiceInterface;

namespace SCA.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            // Add your application services here
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductMapper, ProductMapper>();

            return services;
        }
    }
}
