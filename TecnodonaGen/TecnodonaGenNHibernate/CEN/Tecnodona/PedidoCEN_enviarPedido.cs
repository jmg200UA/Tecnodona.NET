
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


/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CEN.Tecnodona_Pedido_enviarPedido) ENABLED START*/
//  references to other libraries
using TecnodonaGenNHibernate.Enumerated.Tecnodona;

/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CEN.Tecnodona
{
public partial class PedidoCEN
{
public TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN EnviarPedido (string p_codigo)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CEN.Tecnodona_Pedido_enviarPedido) ENABLED START*/

        // Write here your custom code...


        PedidoEN en = _IPedidoCAD.ReadOIDDefault (p_codigo);


        if (en.Estado != EstadoPedidoEnum.enviado) {
                en.Estado = EstadoPedidoEnum.enviado;
                _IPedidoCAD.ModificarPedido (en);
                //throw new ModelException ("Su pedido ha sido enviado.");
        }
        else {
                throw new ModelException ("Su pedido no ha podido ser enviado, intentelo de nuevo.");
        }
        return en;

        /*PROTECTED REGION END*/
}
}
}
