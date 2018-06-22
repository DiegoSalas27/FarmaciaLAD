using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.ViewModel
{
    public class OrdenVentaFormViewModel
    {
        public IEnumerable<Cliente> Clientes { get; set; }

        public OrdenVenta OrdenVenta { get; set; }
    }
}