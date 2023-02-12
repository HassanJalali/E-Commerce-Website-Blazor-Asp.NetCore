using BlazorEcommerce.Client.Services.ProductService;
using Microsoft.AspNetCore.Components;

namespace BlazorEcommerce.Client.Pages
{
    public partial class Index
    {
        [Parameter]
        public string? CategoryUrl { get; set; }
        [Inject]
        private IProductService productService { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await productService.GetProducts(CategoryUrl);
        }
    }
}
