using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;

namespace FarmaciaFinal.Repositories.Implementation
{
    public class MarcaRepository : IMarcaRepository
    {
        ApplicationDbContext context;
        public void Create(Marca entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Marca> Reader()
        {
            using (context = new ApplicationDbContext())
            {
                return context.Marcas.ToList();
            }
        }

        public Marca ReaderById(int id)
        {
            using (context = new ApplicationDbContext())
            {
                return context.Marcas.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Update(Marca entity)
        {
            throw new NotImplementedException();
        }
    }
}