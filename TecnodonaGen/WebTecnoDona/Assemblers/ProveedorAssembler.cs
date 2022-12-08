using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecnodonaGenNHibernate.EN.Tecnodona;
using WebTecnoDona.Models; 

namespace WebTecnoDona.Assemblers
{
    public class ProveedorAssembler
    {
        public ProveedorViewModel ConvertENToModelUI(ProveedorEN en)
        {
            ProveedorViewModel prov = new ProveedorViewModel();
            prov.usuario = en.Usuario;
            prov.Nombre = en.Nombre;
            prov.Contraseña = en.Pass;
            prov.Correo = en.Correo;
            prov.Telefono = en.Telefono;

            return prov;
        }

        public IList<ProveedorViewModel> ConvertListENToModel(IList<ProveedorEN> ens)
        {
            IList<ProveedorViewModel> provs = new List<ProveedorViewModel>();
            foreach(ProveedorEN en in ens)
            {
                provs.Add(ConvertENToModelUI(en));
            }

            return provs;
        }
    }
}