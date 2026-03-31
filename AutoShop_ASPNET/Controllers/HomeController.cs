using System.Diagnostics;
using AutoShop_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            string result = String.Empty;

            for (int i = 1; i <= 3; i++)
            {
                var product = new Product { Id = $"Id{i}", Name = $"Name{i}", Cost = $"Cost{i}" };
                result += $"{product.Id} \n";
                result += $"{product.Name} \n";
                result += $"{product.Cost} \n";
                result += $"\n";
            }

            return result;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
