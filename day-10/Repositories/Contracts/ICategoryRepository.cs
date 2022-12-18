using Entities.Models;

namespace Repositories.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        IEnumerable<Category> GetAllCategories();
        Category GetOneCategoryById(int id);
    }
}
