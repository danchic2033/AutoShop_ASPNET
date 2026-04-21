using AutoShop_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Login(UserProfile userProfile)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
