using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
