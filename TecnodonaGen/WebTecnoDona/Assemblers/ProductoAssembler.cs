using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecnodonaGenNHibernate.EN.Tecnodona;
using WebTecnoDona.Models;

namespace WebTecnoDona.Assemblers
{
    public class ProductoAssembler
    {
        public ProductoViewModel ConvertENToModelUI(ProductoEN en)
        {
            ProductoViewModel prod = new ProductoViewModel();
            prod.NumReferencia = en.NumeroReferencia;
            prod.Valoracion = en.ValoracionMedia;
            prod.Stock = en.Stock;
            prod.Precio = en.Precio;

            return prod;
        }


        public IList<ProductoViewModel> ConvertListENToModel(IList<ProductoEN> ens)
        {
            IList<ProductoViewModel> prods = new List<ProductoViewModel>();
            foreach (ProductoEN en in ens)
            {
                prods.Add(ConvertENToModelUI(en));
            }
            return prods;
        }
    }
}