using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class ProductoService : IProductoService
    {
        IProductoRepository productoRepo;

        public ProductoService()
        {
            productoRepo = new ProductoRepository();
        }

        public void Create(Producto entity)
        {
            this.productoRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.productoRepo.Delete(id);
        }

        public List<Producto> Reader()
        {
            return this.productoRepo.Reader();
        }

        public Producto ReaderById(int id)
        {
            return this.productoRepo.ReaderById(id);
        }

        public void Update(Producto entity)
        {
            this.productoRepo.Update(entity);
        }
    }
}