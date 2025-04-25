using Microsoft.Extensions.DependencyInjection;
using SCA.Domain.RepositoryInterface;
using SCA.Infrastructure.RepositoryImplementation;

namespace SCA.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            // Add your infrastructure services here
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
