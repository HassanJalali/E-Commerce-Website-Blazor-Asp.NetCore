using BlazorEcommerce.Client.Services.ProductService;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http.Json;


namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        [Inject]
        private IProductService productService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await productService.GetProducts();
        }

    }
}
