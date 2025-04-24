using Microsoft.Extensions.DependencyInjection;

namespace SCA.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            // Add your infrastructure services here

            return services;
        }
    }
}
