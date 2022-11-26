using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.EFCore;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _context;

        public ProductController(RepositoryContext context)
        {
            _context = context;  
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View("Index",products);
        }

        public IActionResult GetOneProduct(int id)
        {
            var product = _context
                .Products
                .Where(p => p.Id.Equals(id))
                .SingleOrDefault();

            return View("GetOneProduct", product);
        }

        public IActionResult CreateOneProduct()
        {
            var product = new Product();
            product.ProductName = "Glass";
            product.Price = 2500;
            product.ImageUrl = "/images/products/5.jpg";
            product.Description = "For sunny days.";
            product.AtCreated = DateTime.Now;

            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateOneProductWithView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOneProductWithView(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
