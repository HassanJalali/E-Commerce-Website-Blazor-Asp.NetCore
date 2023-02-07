using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
             Id = 1,
             Title ="شکلات فندقی شونیز 100",
             Description ="در جای خشک و خنک، دور از تابش مستقیم نور آفتاب نگهداری شود.",
             Price = 192000,
             ImageUrl ="https://shoniz.com/wp-content/uploads/2022/08/%D8%B4%D9%88%D9%86%DB%8C%D8%B2-100-%D9%81%D9%86%D8%AF%D9%82%DB%8C.jpg"
            },
            new Product
            {
             Id=2,
             Title ="شونيز طلایی شیری فله",
             Description ="در جای خشک و خنک، دور از تابش مستقیم نور آفتاب نگهداری شود.",
             Price = 340000,
             ImageUrl ="https://shoniz.com/wp-content/uploads/2022/08/Shoniz-Gold_Box-15pc-1400.jpg"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}

