
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface IValoracionCAD
{
ValoracionEN ReadOIDDefault (int id
                             );

void ModifyDefault (ValoracionEN valoracion);

System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size);



int New_ (ValoracionEN valoracion);

void Modify (ValoracionEN valoracion);


void Destroy (int id
              );


ValoracionEN ReadOID (int id
                      );


System.Collections.Generic.IList<ValoracionEN> ReadAll (int first, int size);
}
}
