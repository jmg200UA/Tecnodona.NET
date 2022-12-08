
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface IMetodoPagoCAD
{
MetodoPagoEN ReadOIDDefault (int id
                             );

void ModifyDefault (MetodoPagoEN metodoPago);

System.Collections.Generic.IList<MetodoPagoEN> ReadAllDefault (int first, int size);



int New_ (MetodoPagoEN metodoPago);

void Modify (MetodoPagoEN metodoPago);


void Destroy (int id
              );


MetodoPagoEN ReadOID (int id
                      );


System.Collections.Generic.IList<MetodoPagoEN> ReadAll (int first, int size);
}
}
