using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;

namespace FarmaciaFinal.Repositories.Implementation
{
    public class OrdenVentaRepository : IOrdenVentaRepository
    {
        ApplicationDbContext context;
        public void Create(OrdenVenta entity)
        {
            using (context = new ApplicationDbContext())
            {
                context.OrdenesVenta.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (context = new ApplicationDbContext())
            {
                var orden = context.OrdenesVenta.Where(x => x.Id == id).First();
                context.OrdenesVenta.Remove(orden);
                context.SaveChanges();
            }
        }

        public List<OrdenVenta> Reader()
        {
            using (context = new ApplicationDbContext())
            {
                return context.OrdenesVenta.ToList();
            }
        }

        public OrdenVenta ReaderById(int id)
        {
            using (context = new ApplicationDbContext())
            {
                return context.OrdenesVenta.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Update(OrdenVenta entity)
        {
            using (context = new ApplicationDbContext())
            {
                var ordenVenta = context.OrdenesVenta.Where(x => x.Id == entity.Id).First();
                ordenVenta.Cliente = entity.Cliente;
                ordenVenta.FechaCompra = entity.FechaCompra;
                ordenVenta.Delivery = entity.Delivery;
                ordenVenta.Cliente = entity.Cliente;
                ordenVenta.Estado = entity.Estado;
                ordenVenta.IGV = entity.IGV;
                ordenVenta.Subtotal = entity.Subtotal;
                ordenVenta.Total = entity.Total;
                context.SaveChanges();
            }
        }
    }
}