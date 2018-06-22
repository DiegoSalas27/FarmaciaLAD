using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class LaboratorioService : ILaboratorioService
    {
        ILaboratorioRepository laboratorioRepo;

        public LaboratorioService()
        {
            laboratorioRepo = new LaboratorioRepository();
        }

        public void Create(Laboratorio entity)
        {
            this.laboratorioRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.laboratorioRepo.Delete(id);
        }

        public List<Laboratorio> Reader()
        {
            return this.laboratorioRepo.Reader();
        }

        public Laboratorio ReaderById(int id)
        {
            return this.laboratorioRepo.ReaderById(id);
        }

        public void Update(Laboratorio entity)
        {
            this.laboratorioRepo.Update(entity);
        }
    }
}