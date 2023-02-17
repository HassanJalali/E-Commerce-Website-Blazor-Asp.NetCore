using BlazorEcommerce.Client;
using BlazorEcommerce.Client.ServiceRegistration;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("ODY5OUAzMjMwMkUzMjJFMzBWblY5TGxVK1VXWHVRWmdTZ3g1OXdlUTlyNkxXOXJBTzFUQzVjZ21Sczk4PQ==");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddApplicationServices(builder);
await builder.Build().RunAsync();
