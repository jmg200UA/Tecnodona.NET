using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTecnoDona.Models
{
    public class ProductoViewModel
    {
        [ScaffoldColumn(false)]
        public int NumReferencia { get; set; }

        [ScaffoldColumn(false)]
        [Display(Prompt = "Proveedor del artículo", Description = "Proveedor del atículo", Name = "Proveedor")]
        public string nomProveedor { get; set; }

        [Display(Prompt = "Valoración del producto", Description = "Valoración del producto", Name = "Valoración")]
        [Required(ErrorMessage = "Debe indicar una valoración para el producto")]
        [Range(minimum: 0, maximum: 5, ErrorMessage = "El precio debe ser mayor que 0 y menor que 5")]
        public int Valoracion { get; set; }

        [Display(Prompt = "Stock del producto", Description = "Stock del producto", Name = "Stock")]
        [Required(ErrorMessage = "Debe indicar un stock para el producto")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El stock debe ser mayor que 0 y menor que 10000")]
        public int Stock { get; set; }

        [Display(Prompt = "Precio del artículo", Description = "Precio del atículo", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar un precio para el artículo")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que 0 y menor que 10000")]
        public double Precio { get; set; }
    }
}