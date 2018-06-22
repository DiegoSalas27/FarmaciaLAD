using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;

namespace FarmaciaFinal.Repositories.Implementation
{
    public class ProductoRepository : IProductoRepository
    {
        ApplicationDbContext context;
        public void Create(Producto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Producto> Reader()
        {
            using (context = new ApplicationDbContext())
            {
                return context.Productos.ToList();
            }
        }

        public Producto ReaderById(int id)
        {
            using(context = new ApplicationDbContext())
            {
                return context.Productos.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Update(Producto entity)
        {
            using (context = new ApplicationDbContext())
            {
                var producto = context.Productos.Where(x => x.Id == entity.Id).First();
                producto.Cantidad_por_unidad = entity.Cantidad_por_unidad;
                producto.Categoria = entity.Categoria;
                producto.Composicion = entity.Composicion;
                producto.Fecha_vencimiento = entity.Fecha_vencimiento;
                producto.Laboratorio = entity.Laboratorio;
                producto.Marca = entity.Marca;
                producto.Nombre = entity.Nombre;
                producto.Precio = entity.Precio;
                producto.Presentacion = entity.Presentacion;
                producto.Stock = entity.Stock;
                producto.Tipo_unidad_medida = entity.Tipo_unidad_medida;
                context.SaveChanges();
            }
        }
    }
}