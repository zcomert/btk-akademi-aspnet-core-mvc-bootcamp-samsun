using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;

namespace ProductApp.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }
    }
}
