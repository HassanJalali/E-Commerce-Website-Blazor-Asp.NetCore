using BlazorEcommerce.Client.Services.ProductService;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http.Json;
using System.Runtime.InteropServices;

namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        [Inject]
        private IProductService productService { get; set; }
        protected override void OnInitialized()
        {
            productService.ProductsChanged += StateHasChanged;
        }
        public void Dispose()
        {
            productService.ProductsChanged -= StateHasChanged;
        }

    }
}
