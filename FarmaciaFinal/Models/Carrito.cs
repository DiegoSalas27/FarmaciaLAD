using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class Carrito
    {
        [Key]
        public int RecordId { get; set; }

        public string CartId { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

        [ForeignKey("Producto_Id")]
        public virtual Producto Producto { get; set; }

        public int Producto_Id { get; set; }
    }
}