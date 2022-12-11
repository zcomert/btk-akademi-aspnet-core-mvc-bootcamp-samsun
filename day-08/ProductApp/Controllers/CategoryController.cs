using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;

namespace ProductApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }
    }
}
