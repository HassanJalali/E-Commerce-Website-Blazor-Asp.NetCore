using BlazorEcommerce.Shared;
using Framework.Front.Services;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpService _httpService;

        public ProductService(HttpClient httpClient, IHttpService httpService)
        {
            _httpClient = httpClient;
            _httpService = httpService;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public Product Product { get; set; }

        public event Action ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {

            var result = categoryUrl == null ?
                //await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                //await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/{categoryUrl}");

            await _httpService.Get<ServiceResponse<List<Product>>>("api/product") :
                await _httpService.Get<ServiceResponse<List<Product>>>($"api/product/{categoryUrl}");

            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChanged.Invoke();
        }


    }
}
