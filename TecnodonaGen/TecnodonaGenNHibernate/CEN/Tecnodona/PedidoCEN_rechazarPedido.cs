
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using TecnodonaGenNHibernate.Exceptions;
using TecnodonaGenNHibernate.EN.Tecnodona;
using TecnodonaGenNHibernate.CAD.Tecnodona;


/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CEN.Tecnodona_Pedido_rechazarPedido) ENABLED START*/
//  references to other libraries
using TecnodonaGenNHibernate.Enumerated.Tecnodona;

/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CEN.Tecnodona
{
public partial class PedidoCEN
{
public void RechazarPedido (string p_Pedido_OID)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CEN.Tecnodona_Pedido_rechazarPedido) ENABLED START*/

        // Write here your custom code...
        PedidoEN en = _IPedidoCAD.ReadOIDDefault (p_Pedido_OID);

        if (en.Estado != EstadoPedidoEnum.enviado && en.Estado != EstadoPedidoEnum.recibido) {
                en.Estado = EstadoPedidoEnum.rechazado;
                throw new ModelException ("El pedido ha sido cancelado.");
        }
        else{
                throw new ModelException ("El pedido no puede ser cancelado.");
        }

        /*PROTECTED REGION END*/
}
}
}
