using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;

namespace ProductApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;
        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var products = _manager.ProductService.GetAllProducts();
            TempData["info"] = "Products have been listed.";
            return View(products);
        }

        [HttpGet]
        public IActionResult CreateOneProduct()
        {
            var categories = _manager.CategoryService.GetAllCategories();
            ViewBag.Categories = new SelectList(categories,"CategoryId","CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOneProduct(ProductForInsertionDto productDto)
        {
           
            if (ModelState.IsValid)
            {
                _manager.ProductService.CreateOneProduct(productDto);
                TempData["success"] = "Product has been created";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateOneProduct(int id)
        {
            ViewBag.Categories =
                new SelectList(_manager.Category.GetAllCategories(), 
                "CategoryId", "CategoryName");
            
            var product = _manager.Product.GetOneProductById(id);
            var productDto = _mapper.Map<ProductForUpdateDto>(product);
            return View(productDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateOneProduct(ProductForUpdateDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            if (ModelState.IsValid)
            {
                _manager.Product.Update(product);
                _manager.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult DeleteOneProduct(int id)
        {
            _manager.Product.Delete(new Product() { Id = id });
            _manager.Save();
            return RedirectToAction("Index");
        }

    }
}
