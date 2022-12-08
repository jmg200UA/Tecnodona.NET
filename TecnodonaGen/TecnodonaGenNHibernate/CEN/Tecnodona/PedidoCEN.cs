

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
 *      Definition of the class PedidoCEN
 *
 */
public partial class PedidoCEN
{
private IPedidoCAD _IPedidoCAD;

public PedidoCEN()
{
        this._IPedidoCAD = new PedidoCAD ();
}

public PedidoCEN(IPedidoCAD _IPedidoCAD)
{
        this._IPedidoCAD = _IPedidoCAD;
}

public IPedidoCAD get_IPedidoCAD ()
{
        return this._IPedidoCAD;
}

public string CrearPedido (string p_codigo, string p_seguimiento, int p_numArticulo, double p_totalPrecio, TecnodonaGenNHibernate.Enumerated.Tecnodona.EstadoPedidoEnum p_estado, Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaLlegada, int p_pago, string p_cliente)
{
        PedidoEN pedidoEN = null;
        string oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Codigo = p_codigo;

        pedidoEN.Seguimiento = p_seguimiento;

        pedidoEN.NumArticulo = p_numArticulo;

        pedidoEN.TotalPrecio = p_totalPrecio;

        pedidoEN.Estado = p_estado;

        pedidoEN.FechaInicio = p_fechaInicio;

        pedidoEN.FechaLlegada = p_fechaLlegada;


        if (p_pago != -1) {
                // El argumento p_pago -> Property pago es oid = false
                // Lista de oids codigo
                pedidoEN.Pago = new TecnodonaGenNHibernate.EN.Tecnodona.MetodoPagoEN ();
                pedidoEN.Pago.Id = p_pago;
        }


        if (p_cliente != null) {
                // El argumento p_cliente -> Property cliente es oid = false
                // Lista de oids codigo
                pedidoEN.Cliente = new TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN ();
                pedidoEN.Cliente.Usuario = p_cliente;
        }

        //Call to PedidoCAD

        oid = _IPedidoCAD.CrearPedido (pedidoEN);
        return oid;
}

public void ModificarPedido (string p_Pedido_OID, string p_seguimiento, int p_numArticulo, double p_totalPrecio, TecnodonaGenNHibernate.Enumerated.Tecnodona.EstadoPedidoEnum p_estado, Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaLlegada)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Codigo = p_Pedido_OID;
        pedidoEN.Seguimiento = p_seguimiento;
        pedidoEN.NumArticulo = p_numArticulo;
        pedidoEN.TotalPrecio = p_totalPrecio;
        pedidoEN.Estado = p_estado;
        pedidoEN.FechaInicio = p_fechaInicio;
        pedidoEN.FechaLlegada = p_fechaLlegada;
        //Call to PedidoCAD

        _IPedidoCAD.ModificarPedido (pedidoEN);
}

public void BorrarPedido (string codigo
                          )
{
        _IPedidoCAD.BorrarPedido (codigo);
}

public PedidoEN ConsultarPedido (string codigo
                                 )
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoCAD.ConsultarPedido (codigo);
        return pedidoEN;
}

public PedidoEN ReadOID (string codigo
                         )
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoCAD.ReadOID (codigo);
        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> list = null;

        list = _IPedidoCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> DamePedidoPorProducto (int p_idProducto)
{
        return _IPedidoCAD.DamePedidoPorProducto (p_idProducto);
}
public System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN> DameProductosPorPedido (string p_idPedido)
{
        return _IPedidoCAD.DameProductosPorPedido (p_idPedido);
}
}
}
