using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class Laboratorio
    {
        public int Id { get; set; }

        public int Telefono { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public bool  Estado { get; set; }

        public int Ruc { get; set; }

        public string Razon_social { get; set; }

        public string Ciudad { get; set; }

        public string Pais { get; set; }
    }
}