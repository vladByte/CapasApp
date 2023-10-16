using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controller.Test1Controller
{
    public class Test1Controller : ControllerBase
    {
        public IActionResult Index()
        {
            return View("tituloPagina");
        }

        public IActionResult Saldudo()
        {
            return View("Saludo");
        }

        private IActionResult View(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
