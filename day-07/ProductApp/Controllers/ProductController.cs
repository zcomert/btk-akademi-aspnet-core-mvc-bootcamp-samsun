using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Repositories.EFCore;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index([FromQuery] ProductRequestParameters p)
        {
            var products = _manager.Product.GetAllProducts(p);
            return View("Index",products);
        }

        public IActionResult GetOneProduct(int id)
        {
            var product = _manager.Product.GetOneProductById(id);
            return View("GetOneProduct", product);
        }

        public IActionResult GetAllProductsByCategoryId(int id)
        {
            var products =_manager.Product
                .GetAllProductsByCategoryId(id);

            return View("Index",products);
        }
    }
}
