using Microsoft.AspNetCore.Mvc;
using L02P02_2022_UT_650.Data;
using L02P02_2022_UT_650.Models;
using System.Linq;

namespace L02P02_2022_UT_650.Controllers
{
    public class PedidoDetalleController : Controller
    {
        private readonly LibreriaContext _context;

        public PedidoDetalleController(LibreriaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var detalles = _context.PedidoDetalles.ToList();
            return View(detalles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PedidoDetalle detalle)
        {
            if (ModelState.IsValid)
            {
                _context.PedidoDetalles.Add(detalle);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(detalle);
        }
    }
}
