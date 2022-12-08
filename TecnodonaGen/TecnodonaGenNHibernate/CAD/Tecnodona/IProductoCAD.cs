
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (int numeroReferencia
                           );

void ModifyDefault (ProductoEN producto);

System.Collections.Generic.IList<ProductoEN> ReadAllDefault (int first, int size);



ProductoEN DameDisponibilidad (int numeroReferencia
                               );


int New_ (ProductoEN producto);

void Modify (ProductoEN producto);


void Destroy (int numeroReferencia
              );


ProductoEN ReadOID (int numeroReferencia
                    );


System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size);
}
}
