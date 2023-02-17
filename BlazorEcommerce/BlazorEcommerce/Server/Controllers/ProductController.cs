using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Services.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductById(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }

        [HttpGet("{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl)
        {
            var result = await _productService.GetProductsBycategoryAsync(categoryUrl);
            return Ok(result);
        }
    }
}

