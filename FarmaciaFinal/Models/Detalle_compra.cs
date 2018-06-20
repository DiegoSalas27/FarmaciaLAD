using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class Detalle_compra
    {
        public int Id { get; set; }

        [ForeignKey("Producto_id")]
        public Producto Producto { get; set; }

        [Required]
        [Display(Name = "Producto")]
        public int Producto_id { get; set; }

        [ForeignKey("Compra_id")]
        public OrdenCompra OrdenCompra { get; set; }

        [Required]
        [Display(Name = "Id de compra")]
        public int Compra_id { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio_unitario { get; set; }

        public int Subtotal { get; set; }
    }
}