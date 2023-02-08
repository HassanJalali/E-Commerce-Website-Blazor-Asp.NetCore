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
            var result = await http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
            if(result != null && result.Data != null)
            {
                Products = result.Data;
            }           
        } 
    }
}
