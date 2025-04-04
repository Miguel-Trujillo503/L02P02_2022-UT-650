using Microsoft.AspNetCore.Mvc;
using L02P02_2022_UT_650.Data;
using L02P02_2022_UT_650.Models;
using System.Linq;

namespace L02P02_2022_UT_650.Controllers
{
    public class ComentariosLibrosController : Controller
    {
        private readonly LibreriaContext _context;

        public ComentariosLibrosController(LibreriaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var comentarios = _context.ComentariosLibros.ToList();
            return View(comentarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ComentariosLibros comentario)
        {
            if (ModelState.IsValid)
            {
                _context.ComentariosLibros.Add(comentario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(comentario);
        }
    }
}
