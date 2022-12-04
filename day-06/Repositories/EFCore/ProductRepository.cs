using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class ProductRepository : IProductRepository
    {
        private readonly RepositoryContext _context;
        public ProductRepository(RepositoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts() =>
             _context.Products.ToList();


        public Product GetOneProductById(int id)
        {
            return _context
                .Products
                .Where(p => p.Id.Equals(id))
            .SingleOrDefault();
        }


    }
}
