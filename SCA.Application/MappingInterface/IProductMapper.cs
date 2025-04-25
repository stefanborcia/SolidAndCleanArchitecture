using SCA.Application.ProductDTOs;
using SCA.Domain.ProductEntity;

namespace SCA.Application.MappingInterface
{
    public interface IProductMapper
    {
        ProductDto MapToDto(Product product);
        Product MapToEntity(CreateProductDto createProductDto);
        Product MapToEntity(UpdateProductDto updateProductDto);
    }
}
