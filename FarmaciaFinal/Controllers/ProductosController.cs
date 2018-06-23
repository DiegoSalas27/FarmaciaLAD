using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

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
            var productos = _context.Productos.Include(c => c.Categoria)
                                              .Include(m => m.Marca)
                                              .Include(l => l.Laboratorio)
                                              .Include(p => p.Presentacion).ToList();

            return View(productos);
        }

        public ActionResult Details(int id)
        {
            var producto = _context.Productos.Include(c => c.Categoria)
                                              .Include(m => m.Marca)
                                              .Include(l => l.Laboratorio)
                                              .Include(p => p.Presentacion).SingleOrDefault(m => m.Id == id);

            if (producto == null)
                return HttpNotFound();

            return View(producto);
        }
    }
}