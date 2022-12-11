using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        Category GetOneCategoryById(int id);
        Category CreateOneCategory(Category category);
        void UpdateOneCategory(Category category);
        void DeleteOneCategory(int id);
    }
}
