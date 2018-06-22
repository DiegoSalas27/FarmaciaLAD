using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaFinal.Models;
using FarmaciaFinal.Repositories;
using FarmaciaFinal.Repositories.Implementation;

namespace FarmaciaFinal.Services.Implementation
{
    public class ClienteService : IClienteService
    {
        IClienteRepository clienteRepo;

        public ClienteService()
        {
            clienteRepo = new ClienteRepository();
        }

        public void Create(Cliente entity)
        {
            this.clienteRepo.Create(entity);
        }

        public void Delete(int id)
        {
            this.clienteRepo.Delete(id);
        }

        public List<Cliente> Reader()
        {
            return this.clienteRepo.Reader();
        }

        public Cliente ReaderById(int id)
        {
            return this.clienteRepo.ReaderById(id);
        }

        public void Update(Cliente entity)
        {
            this.clienteRepo.Update(entity);
        }
    }
}