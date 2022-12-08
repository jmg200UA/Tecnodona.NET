using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecnodonaGenNHibernate.EN.Tecnodona;
using WebTecnoDona.Models;

namespace WebTecnoDona.Assemblers
{
    public class ArticuloAssembler
    {

        public ArticuloViewModel ConvertENToModelUI(ArticuloEN en)
        {
            ArticuloViewModel art = new ArticuloViewModel();
            art.Id = en.Id;
            art.Nombre = en.Nombre;
            art.Precio = en.Precio;
            art.Descripcion = en.Descripcion;
            art.IdProducto = en.Producto.NumeroReferencia;
            art.nomProveedor = en.Proveedor.Nombre;

            return art;
        }
        

        public IList<ArticuloViewModel> ConvertListENToModel(IList<ArticuloEN> ens)
        {
            IList<ArticuloViewModel> arts = new List<ArticuloViewModel>();
            foreach(ArticuloEN en in ens)
            {
                arts.Add(ConvertENToModelUI(en));
            }
            return arts;
        }
    }
}