using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecnoDona.Models
{
    public class ArticuloViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Prompt = "Descripción del artículo", Description = "Descripción del atículo", Name = "Descripción")]
        [Required(ErrorMessage = "Debe indicar un nombre para el artículo")]
        [StringLenght(maximumlength: 200, ErrorMessage = "El nombre no puede tener mas de 200 carácteres")]
        public string Descripcion { get; set; }

        [Display(Prompt = "Precio del artículo", Description = "Precio del atículo", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar un precio para el artículo")]
        [DataType(DataTyppe.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que 0 y menor que 10000")]
        public double Precio { get; set; }

        [Display(Prompt = "Stock del artículo", Description = "Stock del atículo", Name = "Stock")]
        [Required(ErrorMessage = "Debe indicar un stock para el artículo")]
        [DataType(DataTyppe.Currency, ErrorMessage = "El stock debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El stock debe ser mayor que 0 y menor que 10000")]
        public double Stock { get; set; }
    }
}