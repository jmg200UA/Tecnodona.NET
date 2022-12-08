
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string usuario
                          );

void ModifyDefault (ClienteEN cliente);

System.Collections.Generic.IList<ClienteEN> ReadAllDefault (int first, int size);



string New_ (ClienteEN cliente);

void Modify (ClienteEN cliente);


void Destroy (string usuario
              );



ClienteEN ReadOID (string usuario
                   );


System.Collections.Generic.IList<ClienteEN> ReadAll (int first, int size);
}
}
