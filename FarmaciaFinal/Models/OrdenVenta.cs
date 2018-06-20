using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class OrdenVenta
    {
        [Key]
        public int MyProperty { get; set; }

        [ForeignKey("Cliente_id")]
        public Cliente Cliente { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public int Cliente_id { get; set; }

        [Required]
        [Display(Name = "Fecha de compra")]
        public DateTime FechaCompra { get; set; }

        public decimal Subtotal { get; set; }

        public decimal IGV { get; set; }

        [Range(1, 20)]
        public decimal  Total { get; set; }

        [Required]
        public string Delivery { get; set; }

        [Required]
        public string Estado { get; set; }
    }
}