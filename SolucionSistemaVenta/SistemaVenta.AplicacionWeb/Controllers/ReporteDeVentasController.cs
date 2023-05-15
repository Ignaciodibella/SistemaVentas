using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    public class ReporteDeVentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
