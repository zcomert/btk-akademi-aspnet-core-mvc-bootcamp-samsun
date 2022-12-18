using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Repositories.EFCore;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index([FromQuery] ProductRequestParameters p)
        {
            var products = _productRepository.GetAllProducts(p);
            return View("Index",products);
        }

        public IActionResult GetOneProduct(int id)
        {
            var product = _productRepository.GetOneProductById(id);
            return View("GetOneProduct", product);
        }
    }
}
