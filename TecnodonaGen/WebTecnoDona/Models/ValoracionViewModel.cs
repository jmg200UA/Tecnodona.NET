using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTecnoDona.Models
{
    public class ValoracionViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Prompt = "Comentario del producto", Description = "Comentario del producto", Name = "Comentario")]
        [Required(ErrorMessage = "Debe indicar un comentario para el artículo")]
        [StringLength(maximumLength: 200, ErrorMessage = "El comentario no puede tener más de 200 carácteres")]
        public string Comentario { get; set; }

        [Display(Prompt = "Valoración del producto", Description = "Valoración del producto", Name = "Valoración")]
        [Required(ErrorMessage = "Debe indicar una valoración para el producto")]
        [Range(minimum: 0, maximum: 5, ErrorMessage = "El precio debe ser mayor que 0 y menor que 5")]
        public int Estrellas { get; set; }

        [ScaffoldColumn(false)]
        [Display(Prompt = "Cliente del artículo", Description = "Cliente del atículo", Name = "Cliente")]
        public string nomCliente { get; set; }

        [ScaffoldColumn(false)]
        [Display(Prompt = "Artículo de la valoración", Description = "Artículo de la valoración", Name = "Artículo")]
        public int IdArticulo { get; set; }

        [ScaffoldColumn(false)]
        [Display(Prompt = "Nombre del artículo", Description = "Nombre del artículo", Name = "Nombre")]
        public string nomArticulo { get; set; }

    }
}