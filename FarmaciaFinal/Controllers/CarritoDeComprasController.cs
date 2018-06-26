using FarmaciaFinal.Models;
using FarmaciaFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Controllers
{
    public class CarritoDeComprasController : Controller
    {
        private ApplicationDbContext _context;

        public CarritoDeComprasController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: CarritoDeCompras
        public ActionResult Index()
        {
            var carrito = CarritoDeCompra.GetCart(this.HttpContext);

            var viewModel = new CarritoDeCompraViewModel
            {
                CartItems = carrito.GetCartItmes(),
                CartTotal = carrito.GetTotal()
            };

            return View(viewModel);
        }

        public ActionResult AddToCart(int id)
        {
            var addedItem = _context.Productos.Single(p => p.Id == id);

            var carrito = CarritoDeCompra.GetCart(this.HttpContext);

            carrito.AddToCart(addedItem);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            var carrito = CarritoDeCompra.GetCart(this.HttpContext);

            string itemName = _context.Carritos.Single(p => p.RecordId == id).Producto.Nombre;

            int itemCount = carrito.RemoveFromCart(id);

            var results = new EliminarCarritoDeCompraViewModel
            {
                Message = Server.HtmlEncode(itemName) + " Ha sido eliminado de su carrito de compras.",
                CartTotal = carrito.GetTotal(),
                CartCount = carrito.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }

        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var carrito = CarritoDeCompra.GetCart(this.HttpContext);

            ViewData["CartCount"] = carrito.GetCount();
            return PartialView("CartSummary");
        }


    }
}