using BlazorEcommerce.Client.Services.ProductService;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorEcommerce.Client.Pages
{
    public partial class ProductDetails
    {
        private Product? product;

        [Parameter]
        public int Id { get; set; }

        [Inject]
        private ProductService ProductService { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            product = ProductService.Products.Find(p => p.Id == Id);
        }

    }
}
