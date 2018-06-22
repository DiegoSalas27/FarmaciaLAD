
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;

namespace FarmaciaFinal.Repositories.Implementation
{
    public class DetalleVentaRepository : IDetalleVentaRepository
    {

        ApplicationDbContext context;
        public void Create(DetalleVenta entity)
        {
            using(context = new ApplicationDbContext())
            {
                context.DetallesVenta.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (context = new ApplicationDbContext())
            {
                var detalle = context.DetallesVenta.Where(x => x.Id == id).First();
                context.DetallesVenta.Remove(detalle);
                context.SaveChanges();
            }
        }

        public List<DetalleVenta> Reader()
        {
            using (context = new ApplicationDbContext())
            {
                return context.DetallesVenta.ToList();
            }
        }

        public DetalleVenta ReaderById(int id)
        {
            using (context = new ApplicationDbContext())
            {
                return context.DetallesVenta.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Update(DetalleVenta entity)
        {
            using (context = new ApplicationDbContext())
            {
                var detalle = context.DetallesVenta.Where(x => x.Id == entity.Id).First();
                detalle.Cantidad = entity.Cantidad;
                detalle.Precio_unitario = entity.Precio_unitario;
                detalle.Subtotal = entity.Subtotal;

                context.SaveChanges();
            }
        }
    }
}