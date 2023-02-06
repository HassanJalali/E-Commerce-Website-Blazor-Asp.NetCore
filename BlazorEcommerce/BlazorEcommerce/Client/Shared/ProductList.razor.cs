using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http.Json;


namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        private List<Product> Products = new();

        protected override async Task OnInitializedAsync()
        {
            await GetProduct();
        }
        private async Task GetProduct()
        {
            Products = await http.GetFromJsonAsync<List<Product>>("api/Product");
        }

    }
}
