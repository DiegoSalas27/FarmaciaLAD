using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class DetalleVentaService : IDetalleVentaService
    {
        IDetalleVentaRepository detalleRepo;

        public DetalleVentaService()
        {
            detalleRepo = new DetalleVentaRepository();
        }

        public void Create(DetalleVenta entity)
        {
            this.detalleRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.detalleRepo.Delete(id);
        }

        public List<DetalleVenta> Reader()
        {
            return this.detalleRepo.Reader();
        }

        public DetalleVenta ReaderById(int id)
        {
            return this.detalleRepo.ReaderById(id);
        }

        public void Update(DetalleVenta entity)
        {
            this.detalleRepo.Update(entity);
        }
    }
}