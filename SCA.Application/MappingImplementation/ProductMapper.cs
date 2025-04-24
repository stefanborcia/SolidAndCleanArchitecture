using SCA.Application.MappingInterface;
using SCA.Application.ProductDTOs;
using SCA.Domain.ProductEntity;

namespace SCA.Application.MappingImplementation
{
    internal class ProductMapper : IProductMapper
    {
        public ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };
        }
        public Product MapToEntity(CreateProductDto createProductDto)
        {
            return new Product
            {
                Name = createProductDto.Name,
                Price = createProductDto.Price,
                Stock = createProductDto.Stock
            };
        }
        public Product MapToEntity(UpdateProductDto updateProductDto)
        {
            return new Product
            {
                Id = updateProductDto.Id,
                Name = updateProductDto.Name,
                Price = updateProductDto.Price,
                Stock = updateProductDto.Stock
            };
        }
    }
}
