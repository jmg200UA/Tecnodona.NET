
using System;
// Definición clase MetodoPagoEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class MetodoPagoEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo tipo
 */
private TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum tipo;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido;



/**
 *	Atributo id
 */
private int id;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public MetodoPagoEN()
{
        pedido = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN>();
}



public MetodoPagoEN(int id, string nombre, TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum tipo, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido
                    )
{
        this.init (Id, nombre, tipo, pedido);
}


public MetodoPagoEN(MetodoPagoEN metodoPago)
{
        this.init (Id, metodoPago.Nombre, metodoPago.Tipo, metodoPago.Pedido);
}

private void init (int id
                   , string nombre, TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum tipo, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Tipo = tipo;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MetodoPagoEN t = obj as MetodoPagoEN;
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
