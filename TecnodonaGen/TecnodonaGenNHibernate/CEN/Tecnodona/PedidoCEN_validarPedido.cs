
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
using TecnodonaGenNHibernate.Enumerated.Tecnodona;


/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CEN.Tecnodona_Pedido_validarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CEN.Tecnodona
{
public partial class PedidoCEN
{
public string ValidarPedido (string p_Pedido_OID)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CEN.Tecnodona_Pedido_validarPedido) ENABLED START*/

        // Write here your custom code...
        PedidoEN en = _IPedidoCAD.ReadOIDDefault (p_Pedido_OID);

        if (en.Estado == EstadoPedidoEnum.carrito) {
                en.Estado = EstadoPedidoEnum.rechazado;
                throw new ModelException ("El pedido ha sido confirmado.");
        }
        else{
                throw new ModelException ("El pedido ya ha sido confirmado o esta rechazado.");
        }

        /*PROTECTED REGION END*/
}
}
}
