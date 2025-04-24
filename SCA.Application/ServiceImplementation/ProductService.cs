using SCA.Application.MappingInterface;
using SCA.Application.ProductDTOs;
using SCA.Application.ServiceInterface;
using SCA.Domain.RepositoryInterface;

namespace SCA.Application.ServiceImplementation
{
    public class ProductService(IProductRepository productRepository, IProductMapper productMapper) : IProductService
    {
        public async Task AddProductAsync(CreateProductDto createProductDto)
        {
            var product = productMapper.MapToEntity(createProductDto);
            await productRepository.AddProductAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await productRepository.DeleteProductAsync(id);
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await productRepository.GetAllProductsAsync();
            return products.Select(product => productMapper.MapToDto(product)).ToList();
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await productRepository.GetProductByIdAsync(id);
            return product == null ? null : productMapper.MapToDto(product);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var product = productMapper.MapToEntity(updateProductDto);
            await productRepository.AddProductAsync(product);
        }
    }
}
