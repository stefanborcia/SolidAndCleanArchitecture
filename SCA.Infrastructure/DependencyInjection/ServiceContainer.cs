using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SCA.Domain.RepositoryInterface;
using SCA.Infrastructure.DatabaseContext;
using SCA.Infrastructure.RepositoryImplementation;

namespace SCA.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services,IConfiguration config)
        {
            // Add your infrastructure services here
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
