using FarmaciaFinal.Models;
using FarmaciaFinal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Controllers
{
    public class OrdenVentasController : Controller
    {
        private ApplicationDbContext _context;

        public OrdenVentasController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var orden_ventas = _context.OrdenesVenta.ToList();

            return View(orden_ventas);
        }

        public ViewResult New()
        {
            var clientes = _context.Clientes.ToList();

            var viewModel = new OrdenVentaFormViewModel
            {
                Clientes = clientes
            };

            return View("OrdenVentaForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var orden_ventas = _context.OrdenesVenta.SingleOrDefault(m => m.Id == id);

            if (orden_ventas == null)
                return HttpNotFound();

            return View(orden_ventas);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(OrdenVenta orden_ventas)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new OrdenVentaFormViewModel
                {
                    Clientes = _context.Clientes.ToList(),
                };

                return View("OrdenVentaForm", viewModel);
            }

            if (orden_ventas.Id == 0)
            {
                _context.OrdenesVenta.Add(orden_ventas);
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "OrdenVentas");
        }
    }
}