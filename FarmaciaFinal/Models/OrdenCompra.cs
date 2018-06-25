using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class OrdenCompra
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fecha de orden")]
        public DateTime Fecha_orden { get; set; }

        public decimal Subtotal { get; set; }

        public decimal IGV { get; set; }

        public decimal Total { get; set; }

        [Required]
        [Display(Name = "Costo de envio")]
        public decimal Costo_envio { get; set; }

    }
}