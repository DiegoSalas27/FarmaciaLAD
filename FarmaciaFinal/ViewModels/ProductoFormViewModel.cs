using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.ViewModel
{
    public class ProductoFormViewModel
    {
        public IEnumerable<Categoria> Categorias { get; set; }

        public IEnumerable<Laboratorio> Laboratorios { get; set; }

        public IEnumerable<Marca> Marcas { get; set; }

        public IEnumerable<Presentacion> Presentaciones { get; set; }

        public Producto Producto { get; set; }
    }
}