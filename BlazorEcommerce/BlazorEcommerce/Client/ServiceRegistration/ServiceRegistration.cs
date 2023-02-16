using BlazorEcommerce.Client.Services.CategoryService;
using BlazorEcommerce.Client.Services.HttpService;
using BlazorEcommerce.Client.Services.ProductService;
using CurrieTechnologies.Razor.SweetAlert2;
using Framework.Front.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

namespace BlazorEcommerce.Client.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services, WebAssemblyHostBuilder builder)
        {
            // using scrutor to find and register services
            services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
            services.AddSyncfusionBlazor();
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddSweetAlert2(options =>
            {
                options.Theme = SweetAlertTheme.Dark;
            });
        }
    }
}
