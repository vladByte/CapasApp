using Microsoft.AspNetCore.Mvc;

namespace CapasApp2.Controllers
{
    public class MedicamentosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MedicamentosList()

        {
            return View();
        }
        public string Saludo(string name)
        {
            return $"Hola {name}";
        }
    }
}