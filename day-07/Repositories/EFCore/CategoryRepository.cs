using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RepositoryContext _context;

        public CategoryRepository(RepositoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetOneCategoryById(int id)
        {
           return _context.Categories
                .Where(c => c.CategoryId.Equals(id))
                .FirstOrDefault();
        }
    }
}
