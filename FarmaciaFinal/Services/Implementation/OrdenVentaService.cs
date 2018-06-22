using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class OrdenVentaService : IOrdenVentaService
    {

        IOrdenVentaRepository ordenRepo;

        public OrdenVentaService()
        {
            ordenRepo = new OrdenVentaRepository();
        }
        public void Create(OrdenVenta entity)
        {
            this.ordenRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.ordenRepo.Delete(id);
        }

        public List<OrdenVenta> Reader()
        {
            return this.ordenRepo.Reader();
        }

        public OrdenVenta ReaderById(int id)
        {
            return this.ordenRepo.ReaderById(id);
        }

        public void Update(OrdenVenta entity)
        {
            this.ordenRepo.Update(entity);
        }
    }
}