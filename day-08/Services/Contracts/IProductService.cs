using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestParameters;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProductsWithDetail();
        IEnumerable<Product> GetAllProducts();
        Product GetOneProductById(int id);
        IEnumerable<Product> GetAllProducts(ProductRequestParameters p);
        IEnumerable<Product> GetAllProductsByCategoryId(int id);
        Product CreateOneProduct(ProductForInsertionDto productDto);
        ProductForUpdateDto GetOneProductForUpdate(int id);
        void UpdateOneProduct(ProductForUpdateDto productDto);
        void DeleteOneProduct(int id);
    }
}
