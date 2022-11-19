using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Diagnostics;

namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            string message = "Merhaba Models-Views-Controllers";
            return View("Index",message);
        }

        public IActionResult Privacy()
        {
            return View();
        }    

        public IActionResult GetProduct()
        {
            //var product = new Product(); // instance
            //product.Id = 1;
            //product.ProductName = "Computer";
            //product.Price = 15000;

            //var product = new Product(1, "Laptop", 17000);

            

            return View(new Product(1,"Computer",5000));
        }

        public IActionResult GetProducts()
        {
            var productList = new List<Product>()
            {
                new Product(1,"Computer",17_000),
                new Product(1,"AirPods",5_000),
                new Product(1,"Sound Set",2_500)
            };
            return View(productList);
        }
    }
}