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

        public Category CreateOneCategory(Category category)
        {
            _manager.Category.Create(category);
            _manager.Save();
            return category;
        }

        public void DeleteOneCategory(int id)
        {
            var category = GetOneCategoryById(id);
            _manager.Category.Delete(category);
            _manager.Save();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _manager.Category.GetAllCategories();    
        }

        public Category GetOneCategoryById(int id)
        {
            var category = _manager.Category.GetOneCategoryById(id);
            if (category is null)
                throw new Exception();
            return category;
        }

        public void UpdateOneCategory(Category category)
        {
            _manager.Category.Update(category);
            _manager.Save();
        }
    }
}
