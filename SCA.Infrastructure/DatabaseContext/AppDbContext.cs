using Microsoft.EntityFrameworkCore;
using SCA.Domain.ProductEntity;

namespace SCA.Infrastructure.DatabaseContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
