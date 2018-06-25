using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace FarmaciaFinal.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        ApplicationDbContext storeDB = new ApplicationDbContext();

        public ActionResult AddressAndPayment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(OrdenVenta ordenVenta)
        {

            ordenVenta.Username = User.Identity.Name;
            ordenVenta.FechaCompra = DateTime.Now;
            ordenVenta.Delivery = "Sí";
            ordenVenta.Estado = "Procede";
            ordenVenta.IGV = 0.18M;

            storeDB.OrdenesVenta.Add(ordenVenta);
            storeDB.SaveChanges();

            var cart = CarritoDeCompra.GetCart(this.HttpContext);
            cart.CreateOrder(ordenVenta);

            return RedirectToAction("Complete",
                new { id = ordenVenta.Id });
        }

        public ActionResult Complete(int id)
        {

            bool isValid = storeDB.OrdenesVenta.Any(
                o => o.Id == id &&
                o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}