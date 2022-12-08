
using System;
// Definición clase ProductoEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class ProductoEN
{
/**
 *	Atributo proveedor
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN> proveedor;



/**
 *	Atributo linea
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN> linea;



/**
 *	Atributo numeroReferencia
 */
private int numeroReferencia;



/**
 *	Atributo articulo
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo;



/**
 *	Atributo valoracionMedia
 */
private int valoracionMedia;



/**
 *	Atributo stock
 */
private int stock;



/**
 *	Atributo precio
 */
private double precio;






public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN> Proveedor {
        get { return proveedor; } set { proveedor = value;  }
}



public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN> Linea {
        get { return linea; } set { linea = value;  }
}



public virtual int NumeroReferencia {
        get { return numeroReferencia; } set { numeroReferencia = value;  }
}



public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> Articulo {
        get { return articulo; } set { articulo = value;  }
}



public virtual int ValoracionMedia {
        get { return valoracionMedia; } set { valoracionMedia = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}





public ProductoEN()
{
        proveedor = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN>();
        linea = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN>();
        articulo = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN>();
}



public ProductoEN(int numeroReferencia, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN> proveedor, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN> linea, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo, int valoracionMedia, int stock, double precio
                  )
{
        this.init (NumeroReferencia, proveedor, linea, articulo, valoracionMedia, stock, precio);
}


public ProductoEN(ProductoEN producto)
{
        this.init (NumeroReferencia, producto.Proveedor, producto.Linea, producto.Articulo, producto.ValoracionMedia, producto.Stock, producto.Precio);
}

private void init (int numeroReferencia
                   , System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN> proveedor, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN> linea, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo, int valoracionMedia, int stock, double precio)
{
        this.NumeroReferencia = numeroReferencia;


        this.Proveedor = proveedor;

        this.Linea = linea;

        this.Articulo = articulo;

        this.ValoracionMedia = valoracionMedia;

        this.Stock = stock;

        this.Precio = precio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
        if (t == null)
                return false;
        if (NumeroReferencia.Equals (t.NumeroReferencia))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.NumeroReferencia.GetHashCode ();
        return hash;
}
}
}
