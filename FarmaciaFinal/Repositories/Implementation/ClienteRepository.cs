using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;

namespace FarmaciaFinal.Repositories.Implementation
{
    public class ClienteRepository : IClienteRepository
    {
        ApplicationDbContext context;

        public void Create(Cliente entity)
        {
           using(context = new ApplicationDbContext())
            {
                context.Clientes.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (context = new ApplicationDbContext())
            {
                var cliente = context.Clientes.Where(x => x.Id == id).First();
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }

        public List<Cliente> Reader()
        {
            using (context = new ApplicationDbContext())
            {
                return context.Clientes.ToList();
            } 
        }

        public Cliente ReaderById(int id)
        {
            using (context = new ApplicationDbContext())
            {
                return context.Clientes.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Update(Cliente entity)
        {
            using (context = new ApplicationDbContext())
            {
                var cliente = context.Clientes.Where(x => x.Id == entity.Id).First();
                cliente.Nombre = entity.Nombre;
                cliente.Ruc = entity.Ruc;
                cliente.Telefono = entity.Telefono;
                cliente.Password = entity.Password;
                cliente.Email = entity.Email;
                cliente.Direccion = entity.Direccion;
                cliente.Puntaje = entity.Puntaje;
                context.SaveChanges();
            }
        }
    }
}