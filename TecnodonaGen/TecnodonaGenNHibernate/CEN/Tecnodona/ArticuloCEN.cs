

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using TecnodonaGenNHibernate.Exceptions;

using TecnodonaGenNHibernate.EN.Tecnodona;
using TecnodonaGenNHibernate.CAD.Tecnodona;


namespace TecnodonaGenNHibernate.CEN.Tecnodona
{
/*
 *      Definition of the class ArticuloCEN
 *
 */
public partial class ArticuloCEN
{
private IArticuloCAD _IArticuloCAD;

public ArticuloCEN()
{
        this._IArticuloCAD = new ArticuloCAD ();
}

public ArticuloCEN(IArticuloCAD _IArticuloCAD)
{
        this._IArticuloCAD = _IArticuloCAD;
}

public IArticuloCAD get_IArticuloCAD ()
{
        return this._IArticuloCAD;
}

public int New_ (string p_nombre, double p_precio, string p_descripcion, string p_proveedor, int p_producto, bool p_disponible)
{
        ArticuloEN articuloEN = null;
        int oid;

        //Initialized ArticuloEN
        articuloEN = new ArticuloEN ();
        articuloEN.Nombre = p_nombre;

        articuloEN.Precio = p_precio;

        articuloEN.Descripcion = p_descripcion;


        if (p_proveedor != null) {
                // El argumento p_proveedor -> Property proveedor es oid = false
                // Lista de oids id
                articuloEN.Proveedor = new TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN ();
                articuloEN.Proveedor.Usuario = p_proveedor;
        }


        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids id
                articuloEN.Producto = new TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN ();
                articuloEN.Producto.NumeroReferencia = p_producto;
        }

        articuloEN.Disponible = p_disponible;

        //Call to ArticuloCAD

        oid = _IArticuloCAD.New_ (articuloEN);
        return oid;
}

public void Modify (int p_Articulo_OID, string p_nombre, double p_precio, string p_descripcion, bool p_disponible)
{
        ArticuloEN articuloEN = null;

        //Initialized ArticuloEN
        articuloEN = new ArticuloEN ();
        articuloEN.Id = p_Articulo_OID;
        articuloEN.Nombre = p_nombre;
        articuloEN.Precio = p_precio;
        articuloEN.Descripcion = p_descripcion;
        articuloEN.Disponible = p_disponible;
        //Call to ArticuloCAD

        _IArticuloCAD.Modify (articuloEN);
}

public void Destroy (int id
                     )
{
        _IArticuloCAD.Destroy (id);
}

public ArticuloEN ReadOID (int id
                           )
{
        ArticuloEN articuloEN = null;

        articuloEN = _IArticuloCAD.ReadOID (id);
        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> list = null;

        list = _IArticuloCAD.ReadAll (first, size);
        return list;
}
}
}
