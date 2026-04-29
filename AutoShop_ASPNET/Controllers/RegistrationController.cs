using AutoShop_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AutoShop_ASPNET.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult SignIn(Registration registration)
        {

            if (registration.Login == registration.Password)
            {
                ModelState.AddModelError("", "Логин и пароль должны отличаться");
            }

            if (!ModelState.IsValid)
            {
                return View(registration);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
