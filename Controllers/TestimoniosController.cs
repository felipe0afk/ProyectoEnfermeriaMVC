using Microsoft.AspNetCore.Mvc;
using ProyectoEnfermeriaMVC.Data;
using ProyectoEnfermeriaMVC.Models;

namespace ProyectoEnfermeriaMVC.Controllers
{
    public class TestimoniosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestimoniosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lista = _context.Testimonios.ToList();
            return View(lista);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Testimonio testimonio)
        {
            if (ModelState.IsValid)
            {
                _context.Testimonios.Add(testimonio);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(testimonio);
        }
    }
}
