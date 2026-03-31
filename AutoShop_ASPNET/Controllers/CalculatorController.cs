using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int num1, int num2, string symbol)
        {
            if (symbol != "+" && symbol != "*" && symbol != null)
            {
                return "Введите символ + или * или оставьте последний сегмент пустым";
            }
            switch (symbol) 
            {
                case "+":
                    return (num1 + num2).ToString();
                case "*":
                    return (num1 * num2).ToString();
                default:
                    return (num1 + num2).ToString();
            }
        }
    }
}
