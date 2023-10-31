using Microsoft.AspNetCore.Mvc;
using CapaNegocio;  
using CapaEntidad;
using CapaDatos;

namespace CapasApp2.Controllers
{
    public class TipoMedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<TipoMedicamentoCLS> ListarTipoMedicamento()
        { 
            TipoMedicamentoBL obj = new TipoMedicamentoBL();
            return obj.listarMedicamentos();
        }

        public string Saludo(string name)
        {
            return $"Saludos {name}";
        }
    }
}
