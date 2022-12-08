
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface IProveedorCAD
{
ProveedorEN ReadOIDDefault (string usuario
                            );

void ModifyDefault (ProveedorEN proveedor);

System.Collections.Generic.IList<ProveedorEN> ReadAllDefault (int first, int size);



string New_ (ProveedorEN proveedor);

void Modify (ProveedorEN proveedor);


void Destroy (string usuario
              );


ProveedorEN ReadOID (string usuario
                     );


System.Collections.Generic.IList<ProveedorEN> ReadAll (int first, int size);
}
}
