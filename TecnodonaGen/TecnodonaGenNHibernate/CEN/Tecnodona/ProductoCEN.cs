

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
 *      Definition of the class ProductoCEN
 *
 */
public partial class ProductoCEN
{
private IProductoCAD _IProductoCAD;

public ProductoCEN()
{
        this._IProductoCAD = new ProductoCAD ();
}

public ProductoCEN(IProductoCAD _IProductoCAD)
{
        this._IProductoCAD = _IProductoCAD;
}

public IProductoCAD get_IProductoCAD ()
{
        return this._IProductoCAD;
}

public ProductoEN DameDisponibilidad (int numeroReferencia
                                      )
{
        ProductoEN productoEN = null;

        productoEN = _IProductoCAD.DameDisponibilidad (numeroReferencia);
        return productoEN;
}

public int New_ (System.Collections.Generic.IList<string> p_proveedor, int p_valoracionMedia, int p_stock, double p_precio)
{
        ProductoEN productoEN = null;
        int oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();

        productoEN.Proveedor = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN>();
        if (p_proveedor != null) {
                foreach (string item in p_proveedor) {
                        TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN en = new TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN ();
                        en.Usuario = item;
                        productoEN.Proveedor.Add (en);
                }
        }

        else{
                productoEN.Proveedor = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN>();
        }

        productoEN.ValoracionMedia = p_valoracionMedia;

        productoEN.Stock = p_stock;

        productoEN.Precio = p_precio;

        //Call to ProductoCAD

        oid = _IProductoCAD.New_ (productoEN);
        return oid;
}

        public void New_(string nomProveedor, int valoracion, int stock, double precio)
        {
            throw new NotImplementedException();
        }

        public void Modify (int p_Producto_OID, int p_valoracionMedia, int p_stock, double p_precio)
{
        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.NumeroReferencia = p_Producto_OID;
        productoEN.ValoracionMedia = p_valoracionMedia;
        productoEN.Stock = p_stock;
        productoEN.Precio = p_precio;
        //Call to ProductoCAD

        _IProductoCAD.Modify (productoEN);
}

public void Destroy (int numeroReferencia
                     )
{
        _IProductoCAD.Destroy (numeroReferencia);
}

public ProductoEN ReadOID (int numeroReferencia
                           )
{
        ProductoEN productoEN = null;

        productoEN = _IProductoCAD.ReadOID (numeroReferencia);
        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> list = null;

        list = _IProductoCAD.ReadAll (first, size);
        return list;
}

        public int New_(int v1, int v2, double v3)
        {
            throw new NotImplementedException();
        }
    }
}
