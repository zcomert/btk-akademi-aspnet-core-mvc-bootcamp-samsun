using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthenticationController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromForm] RegisterDto model)
        {
            if(ModelState.IsValid)
            {
                var applicationUser = new ApplicationUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                };

                var result = await _userManager
                    .CreateAsync(applicationUser, model.Password);
                
                if(result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            return View(ModelState);
        }
    }
}
