using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.EFCore;

namespace ProductApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly RepositoryContext _context;

        public CategoryController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        

       
    }
}
