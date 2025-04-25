using Microsoft.EntityFrameworkCore;
using SCA.Domain.ProductEntity;
using SCA.Domain.RepositoryInterface;
using SCA.Infrastructure.DatabaseContext;

namespace SCA.Infrastructure.RepositoryImplementation
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        public async Task AddProductAsync(Product product)
        {
                await context.Products.AddAsync(product);
                await context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var products = await context.Products.FindAsync(id);

            if (products != null)
            {
                context.Products.Remove(products);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync() => await context.Products.AsNoTracking().ToListAsync();

        public async Task<Product?> GetProductByIdAsync(int id) => await context.Products.FindAsync(id);

        public Task UpdateProductAsync(Product product)
        {
            context.Products.Update(product);
            return context.SaveChangesAsync();
        }
    }
}
