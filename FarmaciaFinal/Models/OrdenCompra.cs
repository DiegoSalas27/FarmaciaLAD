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
        public int Id { get; set; }

        [ForeignKey("Laboratorio_id")]
        public Laboratorio Laboratorio { get; set; }

        [Required]
        [Display(Name = "Laboratorio")]
        public int Laboratorio_id { get; set; }

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