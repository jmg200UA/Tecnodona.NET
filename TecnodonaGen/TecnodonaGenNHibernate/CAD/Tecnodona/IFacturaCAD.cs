
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (int id
                          );

void ModifyDefault (FacturaEN factura);

System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size);



FacturaEN DameArticulo (int id
                        );



void Modify (FacturaEN factura);


void Destroy (int id
              );


FacturaEN ReadOID (int id
                   );


System.Collections.Generic.IList<FacturaEN> ReadAll (int first, int size);


int New_ (FacturaEN factura);
}
}
