using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Models
{
    public class CarritoDeCompra
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        string CarritoDeCompraId { get; set; }
        public const string CartSessionKey = "CardId";
        public static CarritoDeCompra GetCart(HttpContextBase context)
        {
            var carrito = new CarritoDeCompra();
            carrito.CarritoDeCompraId = carrito.GetCartId(context);
            return carrito;
        }

        public static CarritoDeCompra GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public void AddToCart(Producto producto)
        {
            var cartItem = _context.Carritos.SingleOrDefault(c => c.CartId == CarritoDeCompraId
            && c.Producto_Id == producto.Id);

            if (cartItem == null)
            {
                cartItem = new Carrito
                {
                    Producto_Id = producto.Id,
                    CartId = CarritoDeCompraId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                _context.Carritos.Add(cartItem);
            }
            else {
                cartItem.Count++;
            }

            _context.SaveChanges();
        }

        public int RemoveFromCart(int id) {

            var cartItem = _context.Carritos.Single(c => c.CartId == CarritoDeCompraId
            && c.RecordId == id);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else {
                    _context.Carritos.Remove(cartItem);
                }
                _context.SaveChanges();
            }
            return itemCount;
        }

        public void EmptyCart()
        {
            var cartItems = _context.Carritos.Where(c => c.CartId == CarritoDeCompraId);

            foreach (var cartItem in cartItems)
            {
                _context.Carritos.Remove(cartItem);
            }
            _context.SaveChanges();
        }

        public List<Carrito> GetCartItmes()
        {
            return _context.Carritos.Where(c => c.CartId == CarritoDeCompraId).ToList();
        }

        public int GetCount()
        {
            int? count = (from cartItems in _context.Carritos
                          where cartItems.CartId == CarritoDeCompraId
                          select (int?)cartItems.Count).Sum();
            return count ?? 0;
        }

        public decimal GetTotal()
        {
            decimal? total = (from cartItems in _context.Carritos
                              where cartItems.CartId == CarritoDeCompraId
                              select (int?)cartItems.Count *
                              cartItems.Producto.Precio).Sum();

            return total ?? decimal.Zero;
        }

        public int CreateOrder(OrdenVenta ordenVenta)
        {
            decimal orderTotal = 0;

            var cartItems = GetCartItmes();

            foreach (var item in cartItems)
            {
                var detalle_venta = new DetalleVenta
                {
                    Producto_id = item.Producto_Id,
                    Orden_id = ordenVenta.Id,
                    Precio_unitario = item.Producto.Precio,
                    Cantidad = item.Count
                };

                orderTotal += (item.Count * item.Producto.Precio);

                _context.DetallesVenta.Add(detalle_venta);
            }

            ordenVenta.Total = orderTotal;

            _context.SaveChanges();

            EmptyCart();

            return ordenVenta.Id;
        }

        public string GetCartId(HttpContextBase context) //allows access to cookies
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] = context.User.Identity.Name;
                }
                else {
                    Guid tempCartId = Guid.NewGuid();

                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return context.Session[CartSessionKey].ToString();
        }

        public void MigrateCart(string Email)
        {
            var shoppingCart = _context.Carritos.Where(c => c.CartId == CarritoDeCompraId);

            foreach (Carrito item in shoppingCart)
            {
                item.CartId = Email;
            }
            _context.SaveChanges();
        }
    }
}