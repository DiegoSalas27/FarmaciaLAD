using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class PresentacionService : IPresentacionService
    {
        IPresentacionRepository presentacionRepo;

        public PresentacionService()
        {
            presentacionRepo = new PresentacionRepository();
        }

        public void Create(Presentacion entity)
        {
            this.presentacionRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.presentacionRepo.Delete(id);
        }

        public List<Presentacion> Reader()
        {
            return this.presentacionRepo.Reader();
        }

        public Presentacion ReaderById(int id)
        {
            return this.presentacionRepo.ReaderById(id);
        }

        public void Update(Presentacion entity)
        {
            this.presentacionRepo.Update(entity);
        }
    }
}