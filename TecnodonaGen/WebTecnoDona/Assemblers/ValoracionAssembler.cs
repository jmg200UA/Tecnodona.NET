using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecnodonaGenNHibernate.EN.Tecnodona;
using WebTecnoDona.Models;

namespace WebTecnoDona.Assemblers
{
    public class ValoracionAssembler
    {
        public ValoracionViewModel ConvertENToModelUI(ValoracionEN en)
        {
            ValoracionViewModel val = new ValoracionViewModel();
            val.Id = en.Id;
            val.Comentario = en.Comentario;
            val.Estrellas = en.Estrellas;
            val.nomCliente = en.Cliente.Nombre;
            val.IdArticulo = en.Articulo.Id;
            val.nomArticulo = en.Articulo.Nombre;

            return val;
        }


        public IList<ValoracionViewModel> ConvertListENToModel(IList<ValoracionEN> ens)
        {
            IList<ValoracionViewModel> vals = new List<ValoracionViewModel>();
            foreach (ValoracionEN en in ens)
            {
                vals.Add(ConvertENToModelUI(en));
            }
            return vals;
        }
    }
}