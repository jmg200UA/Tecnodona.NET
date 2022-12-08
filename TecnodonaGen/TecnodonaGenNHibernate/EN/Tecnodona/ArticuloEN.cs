
using System;
// Definición clase ArticuloEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class ArticuloEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo proveedor
 */
private TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN proveedor;



/**
 *	Atributo factura
 */
private TecnodonaGenNHibernate.EN.Tecnodona.FacturaEN factura;



/**
 *	Atributo valoracion
 */
private TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN valoracion;



/**
 *	Atributo producto
 */
private TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN producto;



/**
 *	Atributo disponible
 */
private bool disponible;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN Proveedor {
        get { return proveedor; } set { proveedor = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}



public virtual bool Disponible {
        get { return disponible; } set { disponible = value;  }
}





public ArticuloEN()
{
}



public ArticuloEN(int id, string nombre, double precio, string descripcion, TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN proveedor, TecnodonaGenNHibernate.EN.Tecnodona.FacturaEN factura, TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN valoracion, TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN producto, bool disponible
                  )
{
        this.init (Id, nombre, precio, descripcion, proveedor, factura, valoracion, producto, disponible);
}


public ArticuloEN(ArticuloEN articulo)
{
        this.init (Id, articulo.Nombre, articulo.Precio, articulo.Descripcion, articulo.Proveedor, articulo.Factura, articulo.Valoracion, articulo.Producto, articulo.Disponible);
}

private void init (int id
                   , string nombre, double precio, string descripcion, TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN proveedor, TecnodonaGenNHibernate.EN.Tecnodona.FacturaEN factura, TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN valoracion, TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN producto, bool disponible)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Precio = precio;

        this.Descripcion = descripcion;

        this.Proveedor = proveedor;

        this.Factura = factura;

        this.Valoracion = valoracion;

        this.Producto = producto;

        this.Disponible = disponible;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ArticuloEN t = obj as ArticuloEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
