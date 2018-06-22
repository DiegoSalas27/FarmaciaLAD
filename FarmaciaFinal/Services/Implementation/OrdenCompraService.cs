using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class OrdenCompraService : IOrdenCompraService
    {

        IOrdenCompraRepository ordenRepo;

        public OrdenCompraService()
        {
            ordenRepo = new OrdenCompraRepository();
        }

        public void Create(OrdenCompra entity)
        {
            this.ordenRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.ordenRepo.Delete(id);
        }

        public List<OrdenCompra> Reader()
        {
            return this.ordenRepo.Reader();
        }

        public OrdenCompra ReaderById(int id)
        {
            return this.ordenRepo.ReaderById(id);
        }

        public void Update(OrdenCompra entity)
        {
            this.ordenRepo.Update(entity);
        }
    }
}