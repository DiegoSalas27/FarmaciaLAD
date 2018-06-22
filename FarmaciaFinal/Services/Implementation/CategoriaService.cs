using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class CategoriaService : ICategoriaService
    {
        ICategoriaRepository categoriaRepo;
        public CategoriaService()
        {
            categoriaRepo = new CategoriaRepository();
        }
        public void Create(Categoria entity)
        {
            categoriaRepo.Create(entity);
        }

        public void Delete(int id)
        {
            categoriaRepo.Delete(id);
        }

        public List<Categoria> Reader()
        {
            return categoriaRepo.Reader();
        }

        public Categoria ReaderById(int id)
        {
            return categoriaRepo.ReaderById(id);
        }

        public void Update(Categoria entity)
        {
            categoriaRepo.Update(entity);
        }
    }
}