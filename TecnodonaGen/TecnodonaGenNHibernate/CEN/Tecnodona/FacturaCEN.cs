

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
 *      Definition of the class FacturaCEN
 *
 */
public partial class FacturaCEN
{
private IFacturaCAD _IFacturaCAD;

public FacturaCEN()
{
        this._IFacturaCAD = new FacturaCAD ();
}

public FacturaCEN(IFacturaCAD _IFacturaCAD)
{
        this._IFacturaCAD = _IFacturaCAD;
}

public IFacturaCAD get_IFacturaCAD ()
{
        return this._IFacturaCAD;
}

public FacturaEN DameArticulo (int id
                               )
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaCAD.DameArticulo (id);
        return facturaEN;
}

public void Modify (int p_Factura_OID)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_Factura_OID;
        //Call to FacturaCAD

        _IFacturaCAD.Modify (facturaEN);
}

public void Destroy (int id
                     )
{
        _IFacturaCAD.Destroy (id);
}

public FacturaEN ReadOID (int id
                          )
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaCAD.ReadOID (id);
        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> list = null;

        list = _IFacturaCAD.ReadAll (first, size);
        return list;
}
public int New_ (string p_pedido)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();

        if (p_pedido != null) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                facturaEN.Pedido = new TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN ();
                facturaEN.Pedido.Codigo = p_pedido;
        }

        //Call to FacturaCAD

        oid = _IFacturaCAD.New_ (facturaEN);
        return oid;
}
}
}
