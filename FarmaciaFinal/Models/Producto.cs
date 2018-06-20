using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Composicion { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public int Cantidad_por_unidad { get; set; }

        [Required]
        [Display(Name = "Tipo de unidad de medida")]
        public string Tipo_unidad_medida { get; set; }

        public DateTime Fecha_vencimiento { get; set; }

        [ForeignKey("Categoria_id")]
        public Categoria Categoria { get; set; }

        [Required]
        [Display(Name = "Categoria")]
        public int Categoria_id { get; set; }

        [ForeignKey("Presentacion_id")]
        public Presentacion Presentacion { get; set; }

        [Required]
        [Display(Name = "Presentacion")]
        public int Presentacion_id { get; set; }

        [ForeignKey("Laboratorio_id")]
        public Laboratorio Laboratorio { get; set; }

        [Required]
        [Display(Name = "Laboratorio")]
        public int Laboratorio_id { get; set; }

        [ForeignKey("Marca_id")]
        public Marca Marca { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public int Marca_id { get; set; }


    }
}