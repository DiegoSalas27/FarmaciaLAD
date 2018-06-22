using FarmaciaFinal.Models;
using FarmaciaFinal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Controllers
{
    public class Detalle_ventasController : Controller
    {
        private ApplicationDbContext _context;

        public Detalle_ventasController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var detalle_ventas = _context.Detalle_Ventas.ToList();

            return View(detalle_ventas);
        }

        public ViewResult New()
        {
            var productos = _context.Productos.ToList();
            var ordenes_venta = _context.OrdenVentas.ToList();

            var viewModel = new Detalle_ventaFormViewModel
            {
                Productos = productos,
                OrdenesVenta = ordenes_venta
            };

            return View("Detalle_ventaForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var detalle_venta = _context.Detalle_Ventas.SingleOrDefault(m => m.Id == id);

            if (detalle_venta == null)
                return HttpNotFound();

            return View(detalle_venta);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Detalle_venta detalle_Venta)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new Detalle_ventaFormViewModel
                {
                    Productos = _context.Productos.ToList(),
                    OrdenesVenta = _context.OrdenVentas.ToList()
                };

                return View("Detalle_ventaForm", viewModel);
            }

            if (detalle_Venta.Id == 0)
            {
                _context.Detalle_Ventas.Add(detalle_Venta);
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Detalle_ventas");
        }
    }
}