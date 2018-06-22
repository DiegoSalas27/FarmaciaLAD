using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;

namespace FarmaciaFinal.Repositories.Implementation
{
    public class LaboratorioRepository : ILaboratorioRepository
    {

        ApplicationDbContext context;
        public void Create(Laboratorio entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Laboratorio> Reader()
        {
            using (context = new ApplicationDbContext())
            {
                return context.Laboratorios.ToList();
            }
        }

        public Laboratorio ReaderById(int id)
        {
            using (context = new ApplicationDbContext())
            {
                return context.Laboratorios.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Update(Laboratorio entity)
        {
            throw new NotImplementedException();
        }
    }
}