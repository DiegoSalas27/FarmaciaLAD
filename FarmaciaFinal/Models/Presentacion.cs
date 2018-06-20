using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class Presentacion
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}