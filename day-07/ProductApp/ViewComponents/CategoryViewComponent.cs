using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace ProductApp.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategories();
            return View(categories);
        }
    }
}
