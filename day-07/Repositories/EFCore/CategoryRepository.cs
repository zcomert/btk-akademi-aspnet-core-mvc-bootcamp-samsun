using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
            
        }

        public IEnumerable<Category> GetAllCategories() => FindAll();
        

        public Category GetOneCategoryById(int id) =>       
            FindById(c => c.CategoryId.Equals(id));
        
    }
}
