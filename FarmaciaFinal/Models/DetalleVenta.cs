using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class DetalleVenta 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 100)]
        public int Cantidad { get; set; }

        public decimal Precio_unitario { get; set; }

        public decimal Subtotal { get; set; }

        [ForeignKey("Orden_id")]
        public OrdenVenta OrdenVenta { get; set; }

        [Required]
        [Display(Name = "Numero de orden")]
        public int Orden_id { get; set; }

        [ForeignKey("Producto_id")]
        public Producto Producto { get; set; }

        [Required]
        [Display(Name = "Producto")]
        public int Producto_id { get; set; }
    }
}