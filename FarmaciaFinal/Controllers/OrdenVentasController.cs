using FarmaciaFinal.Models;
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

        // GET: OrdenVentas
        public ViewResult Index()
        {
            var ordenes = _context.OrdenesVenta.ToList();

            return View(ordenes);
        }


    }
}