using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetOneProductById(int id);
    }
}
