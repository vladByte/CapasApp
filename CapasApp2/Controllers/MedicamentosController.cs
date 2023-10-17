using Microsoft.AspNetCore.Mvc;

namespace CapasApp2.Controllers
{
    public class MedicamentosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
