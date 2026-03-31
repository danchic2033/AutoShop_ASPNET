using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            DateTime dateTime = DateTime.Now;

            var result = String.Empty;

            if (dateTime.Hour < 6)
            {
                result = "Доброй ночи";
            }
            else if (dateTime.Hour < 12)
            {
                result = "Доброе утро";
            }
            else if (dateTime.Hour < 18)
            {
                result = "Добрый день";
            }
            else
            {
                result = "Добрый вечер";
            }
            return result;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
