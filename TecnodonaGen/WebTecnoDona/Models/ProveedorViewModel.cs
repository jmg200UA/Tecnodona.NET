using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTecnoDona.Models
{
    public class ProveedorViewModel
    {
        [ScaffoldColumn(false)]
        public string usuario { get; set; }

        [Display(Prompt = "Nombre del Proveedor", Description = "Nombre del Proveedor", Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre para el proveedor")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 carácteres")]
        public string Nombre { get; set; }

        [Display(Prompt = "Contraseña del Proveedor", Description = "Contraseña del Proveedor", Name = "Contraseña")]
        [Required(ErrorMessage = "Debe indicar una contraseña para el proveedor")]
        [DataType(DataType.Password, ErrorMessage = "La contraseña debe tener un formato adecuado")]
        public string Contraseña { get; set; }

        [Display(Prompt = "Correo del Proveedor", Description = "Correo del Proveedor", Name = "Correo")]
        [Required(ErrorMessage = "Debe indicar un correo para el proveedor")]
        [DataType(DataType.EmailAddress, ErrorMessage = "El correo debe tener un formato adecuado")]
        public string Correo { get; set; }

        [Display(Prompt = "Teléfono del Proveedor", Description = "Télefono del Proveedor", Name = "Teléfono")]
        [Required(ErrorMessage = "Debe indicar un teléfono para el proveedor")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "El teléfono debe tener un formato adecuado")]
        public int Telefono { get; set; }

    }
}