using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Dtos
{
    public class OrdenVentaDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Username { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public string Delivery { get; set; }

        [ScaffoldColumn(false)]
        public string Estado { get; set; }
    }
}