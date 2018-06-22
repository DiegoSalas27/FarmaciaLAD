using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Controllers
{
    public class ProductosController : Controller
    {
        private ApplicationDbContext _context;

        public ProductosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var productos = _context.Productos.ToList();

            return View(productos);
        }

        public ActionResult Details(int id)
        {
            var producto = _context.Productos.Where(m => m.Id == id);

            if (producto == null)
                return HttpNotFound();

            return View(producto);
        }
    }
}