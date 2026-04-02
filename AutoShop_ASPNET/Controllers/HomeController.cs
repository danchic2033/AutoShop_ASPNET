using System.Diagnostics;
using AutoShop_ASPNET.Models;
using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductsRepository.GetAll();

            return View(products);
        }
    }
}
