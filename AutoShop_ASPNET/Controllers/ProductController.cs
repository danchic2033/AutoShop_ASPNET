using AutoShop_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {
            string result = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                var product = new Product { Id = $"Id{i}", Name = $"Name{i}", Cost = $"Cost{i}", Description = $"Description{i}" };
                
                if (i == id)
                {
                    result += $"{product.Id} \n";
                    result += $"{product.Name} \n";
                    result += $"{product.Cost} \n";
                    result += $"{product.Description} \n";
                }
            }

            return result;
        }
    }
}
