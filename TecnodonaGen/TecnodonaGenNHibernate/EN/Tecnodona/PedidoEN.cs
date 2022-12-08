
using System;
// Definición clase PedidoEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class PedidoEN
{
/**
 *	Atributo codigo
 */
private string codigo;



/**
 *	Atributo seguimiento
 */
private string seguimiento;



/**
 *	Atributo numArticulo
 */
private int numArticulo;



/**
 *	Atributo totalPrecio
 */
private double totalPrecio;



/**
 *	Atributo estado
 */
private TecnodonaGenNHibernate.Enumerated.Tecnodona.EstadoPedidoEnum estado;



/**
 *	Atributo fechaInicio
 */
private Nullable<DateTime> fechaInicio;



/**
 *	Atributo fechaLlegada
 */
private Nullable<DateTime> fechaLlegada;



/**
 *	Atributo pago
 */
private TecnodonaGenNHibernate.EN.Tecnodona.MetodoPagoEN pago;



/**
 *	Atributo cliente
 */
private TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN cliente;



/**
 *	Atributo linea
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN> linea;



/**
 *	Atributo factura
 */
private TecnodonaGenNHibernate.EN.Tecnodona.FacturaEN factura;






public virtual string Codigo {
        get { return codigo; } set { codigo = value;  }
}



public virtual string Seguimiento {
        get { return seguimiento; } set { seguimiento = value;  }
}



public virtual int NumArticulo {
        get { return numArticulo; } set { numArticulo = value;  }
}



public virtual double TotalPrecio {
        get { return totalPrecio; } set { totalPrecio = value;  }
}



public virtual TecnodonaGenNHibernate.Enumerated.Tecnodona.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}



public virtual Nullable<DateTime> FechaLlegada {
        get { return fechaLlegada; } set { fechaLlegada = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.MetodoPagoEN Pago {
        get { return pago; } set { pago = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN> Linea {
        get { return linea; } set { linea = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}





public PedidoEN()
{
        linea = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN>();
}



public PedidoEN(string codigo, string seguimiento, int numArticulo, double totalPrecio, TecnodonaGenNHibernate.Enumerated.Tecnodona.EstadoPedidoEnum estado, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaLlegada, TecnodonaGenNHibernate.EN.Tecnodona.MetodoPagoEN pago, TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN cliente, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN> linea, TecnodonaGenNHibernate.EN.Tecnodona.FacturaEN factura
                )
{
        this.init (Codigo, seguimiento, numArticulo, totalPrecio, estado, fechaInicio, fechaLlegada, pago, cliente, linea, factura);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (Codigo, pedido.Seguimiento, pedido.NumArticulo, pedido.TotalPrecio, pedido.Estado, pedido.FechaInicio, pedido.FechaLlegada, pedido.Pago, pedido.Cliente, pedido.Linea, pedido.Factura);
}

private void init (string codigo
                   , string seguimiento, int numArticulo, double totalPrecio, TecnodonaGenNHibernate.Enumerated.Tecnodona.EstadoPedidoEnum estado, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaLlegada, TecnodonaGenNHibernate.EN.Tecnodona.MetodoPagoEN pago, TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN cliente, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN> linea, TecnodonaGenNHibernate.EN.Tecnodona.FacturaEN factura)
{
        this.Codigo = codigo;


        this.Seguimiento = seguimiento;

        this.NumArticulo = numArticulo;

        this.TotalPrecio = totalPrecio;

        this.Estado = estado;

        this.FechaInicio = fechaInicio;

        this.FechaLlegada = fechaLlegada;

        this.Pago = pago;

        this.Cliente = cliente;

        this.Linea = linea;

        this.Factura = factura;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
        if (t == null)
                return false;
        if (Codigo.Equals (t.Codigo))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Codigo.GetHashCode ();
        return hash;
}
}
}
