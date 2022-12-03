using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
