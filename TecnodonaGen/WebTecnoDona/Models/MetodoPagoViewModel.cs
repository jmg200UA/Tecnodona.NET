using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTecnoDona.Models
{
    public class MetodoPagoViewModel
    {
        [ScaffoldColumn(false)]
        [Display(Prompt = "Nombre tipo de pago", Description = "Nombre tipo de pago", Name = "Nombre")]
        public string Nombre { get; set; }

        [ScaffoldColumn(false)]
        [Display(Prompt = "Id tipo de pago", Description = "Id tipo de pago", Name = "Id")]
        public int Id { get; set; }
    }

}