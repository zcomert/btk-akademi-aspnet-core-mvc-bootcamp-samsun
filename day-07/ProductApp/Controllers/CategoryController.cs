using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Repositories.EFCore;

namespace ProductApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepositoryManager _manager;

        public CategoryController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var categories = _manager.Category.GetAllCategories();
            return View(categories);
        }
    }
}
