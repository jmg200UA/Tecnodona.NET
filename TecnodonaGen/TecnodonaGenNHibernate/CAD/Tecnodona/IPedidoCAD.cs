
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface IPedidoCAD
{
PedidoEN ReadOIDDefault (string codigo
                         );

void ModifyDefault (PedidoEN pedido);

System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size);




string CrearPedido (PedidoEN pedido);


System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> ValidarPedido (string p_pedido);


void ModificarPedido (PedidoEN pedido);


void BorrarPedido (string codigo
                   );


PedidoEN ConsultarPedido (string codigo
                          );


PedidoEN ReadOID (string codigo
                  );


System.Collections.Generic.IList<PedidoEN> ReadAll (int first, int size);


System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> DamePedidoPorProducto (int p_idProducto);


System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN> DameProductosPorPedido (string p_idPedido);
}
}
