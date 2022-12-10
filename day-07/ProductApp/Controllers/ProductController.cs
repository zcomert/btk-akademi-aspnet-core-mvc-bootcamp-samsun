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
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository, 
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index([FromQuery] ProductRequestParameters p)
        {
            // Categories al ve View gönder
            var categories = _categoryRepository.GetAllCategories();
            var products = _productRepository.GetAllProducts(p);

            ViewBag.Categories = categories;
            return View("Index",products);
        }

        public IActionResult GetOneProduct(int id)
        {
            var product = _productRepository.GetOneProductById(id);
            return View("GetOneProduct", product);
        }

        public IActionResult GetAllProductsByCategoryId(int id)
        {
            // Categories al ve View gönder
            var categories = _categoryRepository.GetAllCategories();
            ViewBag.Categories = categories;

            var products = _productRepository
                .GetAllProducts()
                .Where(p => p.CategoryId.Equals(id))
                .ToList();

            return View("Index",products);
        }
    }
}
