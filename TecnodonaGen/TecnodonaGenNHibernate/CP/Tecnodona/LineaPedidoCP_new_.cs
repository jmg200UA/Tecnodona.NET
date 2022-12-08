
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



/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CP.Tecnodona_LineaPedido_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CP.Tecnodona
{
public partial class LineaPedidoCP : BasicCP
{
public TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN New_ (int p_cantidad, int p_producto, string p_pedido)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CP.Tecnodona_LineaPedido_new_) ENABLED START*/

        ILineaPedidoCAD lineaPedidoCAD = null;
        LineaPedidoCEN lineaPedidoCEN = null;
        PedidoCAD pedidoCAD = null;
        PedidoCEN pedidoCEN = null;

        TecnodonaGenNHibernate.EN.Tecnodona.LineaPedidoEN result = null;


        try
        {
                SessionInitializeTransaction ();
                lineaPedidoCAD = new LineaPedidoCAD (session);
                lineaPedidoCEN = new  LineaPedidoCEN (lineaPedidoCAD);
                pedidoCAD = new PedidoCAD (session);
                pedidoCEN = new PedidoCEN (pedidoCAD);



                int oid;
                //Initialized LineaPedidoEN
                LineaPedidoEN lineaPedidoEN;
                lineaPedidoEN = new LineaPedidoEN ();
                lineaPedidoEN.Cantidad = p_cantidad;


                if (p_producto != -1) {
                        lineaPedidoEN.Producto = new TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN ();
                        lineaPedidoEN.Producto.NumeroReferencia = p_producto;
                }


                //Call to LineaPedidoCAD

                oid = lineaPedidoCAD.New_ (lineaPedidoEN);

                PedidoEN pedidoEN = pedidoCEN.ReadOID (p_pedido);
                pedidoEN.TotalPrecio += lineaPedidoEN.Cantidad * lineaPedidoEN.Producto.Precio;

                pedidoCAD.ModifyDefault (pedidoEN);


                result = lineaPedidoCAD.ReadOIDDefault (oid);



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
