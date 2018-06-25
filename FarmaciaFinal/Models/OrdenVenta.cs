using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Models
{
    [Bind(Exclude = "Id")]
    public partial class OrdenVenta
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }
        [StringLength(70)]
        public string Address { get; set; }
        [StringLength(40)]
        public string City { get; set; }
        [StringLength(40)]
        public string State { get; set; }
        [DisplayName("Postal Code")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(40)]
        public string Country { get; set; }
        [StringLength(24)]
        public string Phone { get; set; }
        [DisplayName("Email Address")]

        [ScaffoldColumn(false)]
        [Display(Name = "Fecha de compra")]
        public DateTime FechaCompra { get; set; }

        [ScaffoldColumn(false)]
        public decimal Subtotal { get; set; }

        [ScaffoldColumn(false)]
        public decimal IGV { get; set; }

        [ScaffoldColumn(false)]
        public decimal  Total { get; set; }

        [ScaffoldColumn(false)]
        public string Delivery { get; set; }

        [ScaffoldColumn(false)]
        public string Estado { get; set; }

        public List<DetalleVenta> DetalleVentas { get; set; }
    }
}