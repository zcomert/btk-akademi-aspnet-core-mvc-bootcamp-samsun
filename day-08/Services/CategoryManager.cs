using Entities.Models;
using Services.Contracts;
using Repositories.Contracts;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _manager.Category.GetAllCategories();    
        }

        public Category GetOneCategoryById(int id)
        {
            return _manager.Category.GetOneCategoryById(id);
        }
    }
}
