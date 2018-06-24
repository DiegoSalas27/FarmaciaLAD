using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        ApplicationDbContext _context;

        public CheckoutController()
        {
            _context = new ApplicationDbContext();
        }

        const string PromoCode = "FREE";

        public ActionResult AddressAndPayment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new OrdenVenta();
            TryUpdateModel(order);

            try
            {
                if (string.Equals(values["PromoCode"], PromoCode,
                    StringComparison.OrdinalIgnoreCase) == false)
                {
                    return View(order);
                }
                else
                {
                    order.Username = User.Identity.Name;
                    order.FechaCompra = DateTime.Now;


                    _context.OrdenesVenta.Add(order);
                    _context.SaveChanges();

                    var cart = CarritoDeCompra.GetCart(this.HttpContext);
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",
                        new { id = order.Id });
                }
            }
            catch
            {

                return View(order);
            }
        }

        public ActionResult Complete(int id)
        {

            bool isValid = _context.OrdenesVenta.Any(
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