using Microsoft.AspNetCore.Mvc;
using L02P02_2022_UT_650.Data;
using L02P02_2022_UT_650.Models;
using System.Linq;

namespace L02P02_2022_UT_650.Controllers
{
    public class LibrosController : Controller
    {
        private readonly LibreriaContext _context;

        public LibrosController(LibreriaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var libros = _context.Libros.ToList();
            return View(libros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Add(libro);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }
    }
}
