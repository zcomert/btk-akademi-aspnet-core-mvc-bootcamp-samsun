using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index([FromQuery] ProductRequestParameters p)
        {
            var products = _productService.GetAllProducts(p);
            return View("Index",products);
        }

        public IActionResult GetOneProduct(int id)
        {
            var product = _productService.GetOneProductById(id);
            return View("GetOneProduct", product);
        }

        public IActionResult GetAllProductsByCategoryId(int id)
        {
            var products =_productService
                .GetAllProductsByCategoryId(id);

            return View("Index",products);
        }
    }
}
