
using System;
// Definición clase FacturaEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class FacturaEN
{
/**
 *	Atributo articulo
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pedido
 */
private TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN pedido;






public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> Articulo {
        get { return articulo; } set { articulo = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public FacturaEN()
{
        articulo = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN>();
}



public FacturaEN(int id, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo, TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN pedido
                 )
{
        this.init (Id, articulo, pedido);
}


public FacturaEN(FacturaEN factura)
{
        this.init (Id, factura.Articulo, factura.Pedido);
}

private void init (int id
                   , System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN> articulo, TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN pedido)
{
        this.Id = id;


        this.Articulo = articulo;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
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
