using Microsoft.AspNetCore.Mvc;
using L02P02_2022_UT_650.Data;
using L02P02_2022_UT_650.Models;
using System.Linq;

namespace L02P02_2022_UT_650.Controllers
{
    public class PedidoEncabezadoController : Controller
    {
        private readonly LibreriaContext _context;

        public PedidoEncabezadoController(LibreriaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pedidos = _context.PedidoEncabezados.ToList();
            return View(pedidos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PedidoEncabezado pedido)
        {
            if (ModelState.IsValid)
            {
                _context.PedidoEncabezados.Add(pedido);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(pedido);
        }
    }
}
