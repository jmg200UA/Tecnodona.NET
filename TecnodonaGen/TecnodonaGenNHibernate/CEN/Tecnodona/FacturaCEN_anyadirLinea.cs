
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


/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CEN.Tecnodona_Factura_anyadirLinea) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CEN.Tecnodona
{
public partial class FacturaCEN
{
public void AnyadirLinea (int p_Factura_OID, System.Collections.Generic.IList<int> p_articulo_OIDs)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CEN.Tecnodona_Factura_anyadirLinea) ENABLED START*/

        // Write here your custom code...
        Console.WriteLine ("La factura " + p_Factura_OID + " contiene los articulos: ");
        foreach (int art in p_articulo_OIDs) {
                Console.WriteLine ("- #" + art);
        }

        /*PROTECTED REGION END*/
}
}
}
