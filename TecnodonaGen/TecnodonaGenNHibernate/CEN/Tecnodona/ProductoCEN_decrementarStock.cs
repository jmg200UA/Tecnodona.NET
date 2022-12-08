
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


/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CEN.Tecnodona_Producto_decrementarStock) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CEN.Tecnodona
{
public partial class ProductoCEN
{
public void DecrementarStock (int p_oid, int p_cantidad)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CEN.Tecnodona_Producto_decrementarStock) ENABLED START*/

        // Write here your custom code...

        ProductoEN en = _IProductoCAD.ReadOIDDefault (p_oid);

        if (!(en.Stock >= p_cantidad)) {
                throw new ModelException ("La cantidad es superior al stock del producto");
        }
        en.Stock -= p_cantidad;



        _IProductoCAD.ModifyDefault (en);

        /*PROTECTED REGION END*/
}
}
}
