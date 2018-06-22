using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Repositories.Implementation
{
    public class CategoriaRepository : ICategoriaRepository
    {
        ApplicationDbContext context;


        public void Create(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> Reader()
        {
            using (context = new ApplicationDbContext())
            {
                return context.Categorias.ToList();
            }
        }

        public Categoria ReaderById(int id)
        {
            using (context = new ApplicationDbContext())
            {
                return context.Categorias.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}