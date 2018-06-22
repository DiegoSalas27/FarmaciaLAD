using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;

namespace FarmaciaFinal.Repositories.Implementation
{
    public class PresentacionRepository : IPresentacionRepository
    {
        ApplicationDbContext context;
        public void Create(Presentacion entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Presentacion> Reader()
        {
            using (context = new ApplicationDbContext())
            {
                return context.Presentaciones.ToList();
            }
        }

        public Presentacion ReaderById(int id)
        {
            using(context = new ApplicationDbContext())
            {
                return context.Presentaciones.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Update(Presentacion entity)
        {
            throw new NotImplementedException();
        }
    }
}