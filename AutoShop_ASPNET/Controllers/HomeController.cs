using System.Diagnostics;
using AutoShop_ASPNET.Models;
using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string result = String.Empty;

            var products = ProductsRepository.GetAll();

            foreach (var product in products)
            {
                result += product + Environment.NewLine + Environment.NewLine;
            }

            return result;
        }
    }
}
