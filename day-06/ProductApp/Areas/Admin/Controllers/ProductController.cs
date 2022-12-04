using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repositories.EFCore;

namespace ProductApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly RepositoryContext _context;
        private readonly IMapper _mapper;

        public ProductController(RepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            TempData["info"] = "Products have been listed.";
            return View(products);
        }

        [HttpGet]
        public IActionResult CreateOneProduct()
        {
            var categories = _context.Categories.ToList();
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
                _context.Products.Add(product);
                _context.SaveChanges();
                TempData["success"] = "Product has been created";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateOneProduct(int id)
        {
            // 1. View oluştur
            // 2. İlgili ürünü çekip View Göndermek

            ViewBag.Categories =
                new SelectList(_context.Categories.ToList(), 
                "CategoryId", "CategoryName");
            
            var product = _context
                .Products
                .Where(p => p.Id == id)
                .SingleOrDefault();
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
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult DeleteOneProduct(int id)
        {
            _context.Products.Remove(new Product() { Id = id });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
