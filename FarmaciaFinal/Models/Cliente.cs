using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [ForeignKey("Rol_id")]
        public Rol Rol { get; set; }

        [Display(Name = "Tipo de usuario")]
        public int Rol_id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        public int Telefono { get; set; }

        public string Direccion { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public int Ruc { get; set; }
    }
}