using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class DetalleCompraService : IDetalleCompraService
    {

        IDetalleCompraRepository detalleRepo;

        public DetalleCompraService()
        {
            detalleRepo = new DetalleCompraRepository();
        }

        public void Create(DetalleCompra entity)
        {
            this.detalleRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.detalleRepo.Delete(id);
        }

        public List<DetalleCompra> Reader()
        {
            return this.detalleRepo.Reader();
        }

        public DetalleCompra ReaderById(int id)
        {
            return this.detalleRepo.ReaderById(id);
        }

        public void Update(DetalleCompra entity)
        {
            this.detalleRepo.Update(entity);
        }
    }
}