

using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestParameters;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ProductManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public Product CreateOneProduct(ProductForInsertionDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _manager.Product.Create(product);
            _manager.Save();
            return product;
        }

        public void DeleteOneProduct(int id)
        {
            var product = GetOneProductById(id);
            _manager.Product.Delete(product);
            _manager.Save();
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

        public IEnumerable<Product> GetAllProductsWithDetail()
        {
            return _manager.Product.GetAllProductsWithDetail();
        }

        public Product GetOneProductById(int id)
        {
            var product = _manager.Product.GetOneProductById(id);
            if (product is null)
                throw new Exception();
            return product;
        }

        public ProductForUpdateDto GetOneProductForUpdate(int id)
        {
            var product = GetOneProductById(id);
            var productDto = _mapper.Map<ProductForUpdateDto>(product);
            return productDto;
        }

        public void UpdateOneProduct(ProductForUpdateDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _manager.Product.Update(product);
            _manager.Save();
        }
    }
}
