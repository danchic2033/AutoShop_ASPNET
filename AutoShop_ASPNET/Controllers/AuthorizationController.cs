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

        [HttpPost]
        public IActionResult Login(Authorization authorization)
        {
            if (authorization.Login == authorization.Password)
            {
                ModelState.AddModelError("", "Логин и пароль должны отличаться");
            }

            if (!ModelState.IsValid)
            {
                return View(authorization);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
