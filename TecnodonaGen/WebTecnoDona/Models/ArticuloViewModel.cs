using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTecnoDona.Models
{
    public class ArticuloViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set;}

        [ScaffoldColumn(false)]
        [Display(Prompt = "Proveedor del artículo", Description = "Proveedor del atículo", Name = "Proveedor")]
        public string nomProveedor { get; set; }

        [ScaffoldColumn(false)]
        [Display(Prompt = "Producto del artículo", Description = "Producto del artículo", Name = "Producto")]
        public int IdProducto { get; set; }

        [Display(Prompt = "Nombre del artículo", Description = "Nombre del atículo", Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre para el artículo")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 carácteres")]
        public string Nombre { get; set; }

        [Display(Prompt = "Descripcion del artículo", Description = "Descripción del atículo", Name = "Descripción")]
        [Required(ErrorMessage = "Debe indicar una descripción para el artículo")]
        [StringLength(maximumLength: 200, ErrorMessage = "La descripción no puede tener más de 200 carácteres")]
        public string Descripcion { get; set;}

        [Display(Prompt = "Precio del artículo", Description = "Precio del atículo", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar un precio para el artículo")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que 0 y menor que 10000")]
        public double Precio { get; set; }
    }
}