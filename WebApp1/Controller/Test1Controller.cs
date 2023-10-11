using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controller
{
    public class Test1Controller : ControllerBase
    {
        // public IActionResult Index()
        // {
        //     return View();
        // }

        public String Saludo(string name = "Vlad")
        {
            return "Bienvenido" + name;
        }
    }
}
