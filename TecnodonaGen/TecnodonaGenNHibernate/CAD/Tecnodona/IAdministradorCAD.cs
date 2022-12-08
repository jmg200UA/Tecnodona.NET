
using System;
using TecnodonaGenNHibernate.EN.Tecnodona;

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (string usuario
                                );

void ModifyDefault (AdministradorEN administrador);

System.Collections.Generic.IList<AdministradorEN> ReadAllDefault (int first, int size);



string New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (string usuario
              );


AdministradorEN ReadOID (string usuario
                         );


System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size);
}
}
