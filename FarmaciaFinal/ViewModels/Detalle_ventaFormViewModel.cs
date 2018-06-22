using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.ViewModel
{
    public class Detalle_ventaFormViewModel
    {
        public IEnumerable<OrdenVenta> OrdenesVenta { get; set; }

        public IEnumerable<Producto> Productos { get; set; }

        public Detalle_venta Detalle_Venta { get; set; }
    }
}