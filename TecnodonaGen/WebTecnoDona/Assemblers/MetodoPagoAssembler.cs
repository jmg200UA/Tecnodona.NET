using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecnodonaGenNHibernate.EN.Tecnodona;
using WebTecnoDona.Models;

namespace WebTecnoDona.Assemblers
{
    public class MetodoPagoAssembler
    {
        public MetodoPagoViewModel ConvertENToModel(MetodoPagoEN en)
        {
            MetodoPagoViewModel pago = new MetodoPagoViewModel();
            
            pago.Nombre = en.Nombre;
            pago.Id = en.Id;

            return pago;
        }

        public IList<MetodoPagoViewModel> ConvertListENToModel(IList<MetodoPagoEN> ens)
        {
            IList<MetodoPagoViewModel> pagos = new List<MetodoPagoViewModel>();
            foreach (MetodoPagoEN en in ens)
            {
                pagos.Add(ConvertENToModel(en));
            }
            return pagos;
        }


    }
}