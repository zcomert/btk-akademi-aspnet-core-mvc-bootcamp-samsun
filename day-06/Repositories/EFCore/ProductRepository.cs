using Entities.Models;
using Entities.RequestParameters;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;
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

        public IEnumerable<Product> GetAllProducts(ProductRequestParameters p)
        {
            return _context
                 .Products
                 .FilterProducts(p.MinPrice,p.MaxPrice)
                 .ToList();
        }

        public Product GetOneProductById(int id)
        {
            return _context
                .Products
                .Where(p => p.Id.Equals(id))
            .SingleOrDefault();
        }


    }
}
