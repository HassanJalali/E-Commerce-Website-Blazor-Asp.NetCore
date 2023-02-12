using BlazorEcommerce.Client.Services.CategoryService;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace BlazorEcommerce.Client.Shared
{
    public partial class NavMenu
    {
        private bool collapseNavMenu = true;
        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        [Inject]
        private ICategoryService categoryService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await categoryService.GetCategoriesAsync();
        }

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
