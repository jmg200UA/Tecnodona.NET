
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


/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CEN.Tecnodona_Pedido_dameClientePorPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CEN.Tecnodona
{
public partial class PedidoCEN
{
public System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN> DameClientePorPedido (string p_idProducto)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CEN.Tecnodona_Pedido_dameClientePorPedido_customized) START*/

        return _IPedidoCAD.DameClientePorPedido (p_idProducto);
        /*PROTECTED REGION END*/
}
}
}
