using Microsoft.AspNetCore.Mvc;

namespace ProyectoEnfermeriaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Lactancia() => View();
        public IActionResult Canguro() => View();
        public IActionResult Recursos() => View();
        public IActionResult Contacto() => View();
    }
}
