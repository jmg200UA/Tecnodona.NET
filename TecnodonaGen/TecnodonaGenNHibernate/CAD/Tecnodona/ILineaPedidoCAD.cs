
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int id
                              );

void ModifyDefault (LineaPedidoEN lineaPedido);

System.Collections.Generic.IList<LineaPedidoEN> ReadAllDefault (int first, int size);



int New_ (LineaPedidoEN lineaPedido);

void Modify (LineaPedidoEN lineaPedido);


void Destroy (int id
              );


LineaPedidoEN ReadOID (int id
                       );


System.Collections.Generic.IList<LineaPedidoEN> ReadAll (int first, int size);
}
}
