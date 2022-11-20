using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Create an action
        public IActionResult GetOneProduct()
        {
            // 1. veriyi organize etmek 
            var prd = new Product();
            prd.Id = 1;
            prd.ProductName = "Computer";
            prd.Price = 17_000;

            // 2. view gönder 
            return View("GetOneProduct", prd);
        }

        public IActionResult GetAllProducts()
        {
            var products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                ProductName = "Computer",
                Price = 17_000
            });
            products.Add(new Product(2, "Smart Phone", 15_000));
            products.Add(new Product(3, "AirPods", 5_000));

            return View(products);
        }


    }
}
