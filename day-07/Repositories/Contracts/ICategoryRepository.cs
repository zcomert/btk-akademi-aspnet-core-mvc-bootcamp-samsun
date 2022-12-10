using Entities.Models;

namespace Repositories.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category GetOneCategoryById(int id);
    }
}
