using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.ViewModels
{
    public class CarritoDeCompraViewModel
    {
        public List<Carrito> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}