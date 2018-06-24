using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public partial class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
    }
}