using Microsoft.AspNetCore.Mvc;
using SCA.Application.ProductDTOs;
using SCA.Application.ServiceInterface;

namespace SCA.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] CreateProductDto createProductDto)
        {
            await productService.AddProductAsync(createProductDto);
            return CreatedAtAction(nameof(GetProductById), new { id = createProductDto.Name }, createProductDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductDto updateProductDto)
        {
            if (id != updateProductDto.Id)
            {
                return BadRequest();
            }
            await productService.UpdateProductAsync(updateProductDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await productService.DeleteProductAsync(id);
            return NoContent();
        }
    }
}
