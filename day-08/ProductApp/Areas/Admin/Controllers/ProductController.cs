using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repositories.Contracts;
using Repositories.EFCore;

namespace ProductApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ProductController(IRepositoryManager manager, IMapper mapper)
        {
            _mapper = mapper;
            _manager = manager;
        }

        public IActionResult Index()
        {
            var products = _manager.Product.GetAllProducts();
            TempData["info"] = "Products have been listed.";
            return View(products);
        }

        [HttpGet]
        public IActionResult CreateOneProduct()
        {
            var categories = _manager.Category.GetAllCategories();
            ViewBag.Categories = new SelectList(categories,"CategoryId","CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOneProduct(ProductForInsertionDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);

            if (ModelState.IsValid)
            {
                _manager.Product.Create(product);
                _manager.Save();
                
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
