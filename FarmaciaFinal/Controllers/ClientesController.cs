using FarmaciaFinal.Models;
using FarmaciaFinal.ViewModel;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Controllers
{
    public class ClientesController : Controller
    {
        private ApplicationDbContext _context;

        public ClientesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var viewModel = new ClienteFormViewModel
            {
                Cliente = new Cliente(),
            };

            return View("ClienteForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ClienteFormViewModel
                {
                    Cliente = cliente
                };

                return View("CustomerForm", viewModel);
            }

            if (cliente.Id == 0)
                _context.Clientes.Add(cliente);
            else
            {
                var clienteInDb = _context.Clientes.Single(c => c.Id == cliente.Id);
                clienteInDb.Nombre = cliente.Nombre;
                clienteInDb.Telefono = cliente.Telefono;
                clienteInDb.Direccion = cliente.Direccion;
                clienteInDb.Email = cliente.Email;
                clienteInDb.Password = cliente.Password;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Clientes");
        }

        // GET: Clientes
        public ViewResult Index()
        {
            var clientes = _context.Clientes.ToList();

            return View(clientes);
        }

        public ActionResult Details(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        public ActionResult Edit(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            var viewModel = new ClienteFormViewModel
            {
                Cliente = cliente,
            };

            return View("CustomerForm", viewModel);
        }
    }
}