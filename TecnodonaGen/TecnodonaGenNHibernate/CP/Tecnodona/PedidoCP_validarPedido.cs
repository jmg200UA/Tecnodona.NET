
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using TecnodonaGenNHibernate.EN.Tecnodona;
using TecnodonaGenNHibernate.CAD.Tecnodona;
using TecnodonaGenNHibernate.CEN.Tecnodona;



/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CP.Tecnodona_Pedido_validarPedido) ENABLED START*/
//  references to other libraries
using TecnodonaGenNHibernate.Enumerated.Tecnodona;

/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CP.Tecnodona
{
public partial class PedidoCP : BasicCP
{
public System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> ValidarPedido (string p_pedido)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CP.Tecnodona_Pedido_validarPedido) ENABLED START*/

        IPedidoCAD pedidoCAD = null;
        PedidoCEN pedidoCEN = null;
        LineaPedidoEN lineaPedidoEN = new LineaPedidoEN ();
        FacturaCEN factura = new FacturaCEN ();

        System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN>  result = null;


        try
        {
                SessionInitializeTransaction ();
                pedidoCAD = new PedidoCAD (session);
                pedidoCEN = new  PedidoCEN (pedidoCAD);
                PedidoEN pedidoEN = pedidoCEN.ReadOID (p_pedido);

                if (pedidoEN.Estado == EstadoPedidoEnum.carrito) {
                        pedidoEN.Estado = EstadoPedidoEnum.enviado;
                        pedidoCAD.ModifyDefault (pedidoEN);
                        Console.WriteLine ("El pedido " + pedidoEN.Codigo + " ha sido validado");
                        Console.WriteLine ("Generando factura....");

                        int factura1 = factura.New_ (p_pedido);
                        IList<ProductoEN> lista = pedidoCEN.DameProductosPorPedido (p_pedido);

                        IList<int> listilla = null;

                        foreach (ProductoEN prod in lista) {
                                ArticuloEN art = (ArticuloEN)prod.Articulo;
                                listilla.Add (art.Id);
                                prod.Stock -= 1;
                        }
                        factura.AnyadirLinea (factura1, listilla);
                }


                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
