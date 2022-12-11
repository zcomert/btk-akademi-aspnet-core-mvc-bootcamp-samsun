using Entities.Models;
using Entities.RequestParameters;
using Services.Contracts;
using Repositories.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;

        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _manager.Product.GetAllProducts();
        }

        public IEnumerable<Product> GetAllProducts(ProductRequestParameters p)
        {
            return _manager.Product.GetAllProducts(p);
        }

        public IEnumerable<Product> GetAllProductsByCategoryId(int id)
        {
           return _manager.Product.GetAllProductsByCategoryId(id);
        }

        public Product GetOneProductById(int id)
        {
            var product = _manager.Product.GetOneProductById(id);
            if (product is null)
                throw new Exception();
            return product;
        }
    }
}
