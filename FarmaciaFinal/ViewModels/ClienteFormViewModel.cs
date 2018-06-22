using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.ViewModel
{
    public class ClienteFormViewModel
    {
        public IEnumerable<Rol> Roles { get; set; }

        public Cliente Cliente { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Rol")]
        [Required]
        public int? Rol_id { get; set; }

        [Required]
        public int? Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int Ruc { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Editar Cliente" : "Nuevo Cliente"; 
            }
        }

        public ClienteFormViewModel()
        {
            Id = 0;
        }

        public ClienteFormViewModel(Cliente cliente)
        {
            Id = cliente.Id;
            Name = cliente.Nombre;
            Telefono = cliente.Telefono;
            Direccion = cliente.Direccion;
            Email = cliente.Email;
            Password = cliente.Password;
            Ruc = cliente.Ruc;
            Rol_id = cliente.Rol_id;
        }
    }
}