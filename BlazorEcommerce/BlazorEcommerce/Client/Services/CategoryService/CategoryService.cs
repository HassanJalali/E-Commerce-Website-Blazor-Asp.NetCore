using BlazorEcommerce.Shared;
using Framework.Front.Services;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpService _httpService;

        public CategoryService(HttpClient httpClient, IHttpService httpService)
        {
            _httpClient = httpClient;
            _httpService = httpService;
        }
        public List<Category> Categories { get; set; }

        public async Task GetCategoriesAsync()
        {
            var response = await _httpService.Get<ServiceResponse<List<Category>>>("api/category");

            //var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");

            if (response != null && response.Data != null)
            {
                Categories = response.Data;
            }
        }
    }
}
