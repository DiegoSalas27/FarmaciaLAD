using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class MarcaService : IMarcaService
    {
        IMarcaRepository marcaRepo;

        public MarcaService()
        {
            marcaRepo = new MarcaRepository();
        }

        public void Create(Marca entity)
        {
            this.marcaRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.marcaRepo.Delete(id);
        }

        public List<Marca> Reader()
        {
            return this.marcaRepo.Reader();
        }

        public Marca ReaderById(int id)
        {
            return this.marcaRepo.ReaderById(id);
        }

        public void Update(Marca entity)
        {
            this.marcaRepo.Update(entity);
        }
    }
}