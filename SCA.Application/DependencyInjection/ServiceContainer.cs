using Microsoft.Extensions.DependencyInjection;

namespace SCA.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            // Add your infrastructure services here

            return services;
        }
    }
}
