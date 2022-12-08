
using System;
// Definición clase ProveedorEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class ProveedorEN                                                                    : TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN


{
/**
 *	Atributo articulo
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN> producto;






public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> Articulo {
        get { return articulo; } set { articulo = value;  }
}



public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}





public ProveedorEN() : base ()
{
        articulo = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN>();
        producto = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN>();
}



public ProveedorEN(string usuario, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN> producto
                   , string nombre, String pass, string correo, int telefono, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN> valoracion
                   )
{
        this.init (Usuario, articulo, producto, nombre, pass, correo, telefono, pedido, valoracion);
}


public ProveedorEN(ProveedorEN proveedor)
{
        this.init (Usuario, proveedor.Articulo, proveedor.Producto, proveedor.Nombre, proveedor.Pass, proveedor.Correo, proveedor.Telefono, proveedor.Pedido, proveedor.Valoracion);
}

private void init (string usuario
                   , System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN> producto, string nombre, String pass, string correo, int telefono, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN> valoracion)
{
        this.Usuario = usuario;


        this.Articulo = articulo;

        this.Producto = producto;

        this.Nombre = nombre;

        this.Pass = pass;

        this.Correo = correo;

        this.Telefono = telefono;

        this.Pedido = pedido;

        this.Valoracion = valoracion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProveedorEN t = obj as ProveedorEN;
        if (t == null)
                return false;
        if (Usuario.Equals (t.Usuario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Usuario.GetHashCode ();
        return hash;
}
}
}
