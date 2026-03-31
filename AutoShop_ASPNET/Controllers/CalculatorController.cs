using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class CalculatorController : Controller
    {
        public int Index(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
