using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class CalcController : Controller
    {
        public string Index(int a, int b, string c)
        {
            string result;

            if (c != null && c != "%2B" && c != "*" && c!= "/")
            {
                return "Введенный символ для операции должен быть равен %2B(сложение) либо * либо / либо быть пустым";
            }

            switch (c)
            {
                case "%2B":
                    return (result = (a + b).ToString());
                case "*":
                    return (result = (a * b).ToString());
                case "/":
                    return (result = ((double)a / b).ToString());
                default:
                    return (result = (a + b).ToString());
            }
        }
    }
}
