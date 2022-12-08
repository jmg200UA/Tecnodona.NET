
using System;
// Definición clase LineaPedidoEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class LineaPedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo producto
 */
private TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN producto;



/**
 *	Atributo pedido
 */
private TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN pedido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int id, int cantidad, TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN producto, TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN pedido
                     )
{
        this.init (Id, cantidad, producto, pedido);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (Id, lineaPedido.Cantidad, lineaPedido.Producto, lineaPedido.Pedido);
}

private void init (int id
                   , int cantidad, TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN producto, TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN pedido)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Producto = producto;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
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
