

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
 *      Definition of the class MetodoPagoCEN
 *
 */
public partial class MetodoPagoCEN
{
private IMetodoPagoCAD _IMetodoPagoCAD;

public MetodoPagoCEN()
{
        this._IMetodoPagoCAD = new MetodoPagoCAD ();
}

public MetodoPagoCEN(IMetodoPagoCAD _IMetodoPagoCAD)
{
        this._IMetodoPagoCAD = _IMetodoPagoCAD;
}

public IMetodoPagoCAD get_IMetodoPagoCAD ()
{
        return this._IMetodoPagoCAD;
}

public int New_ (string p_nombre, TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum p_tipo)
{
        MetodoPagoEN metodoPagoEN = null;
        int oid;

        //Initialized MetodoPagoEN
        metodoPagoEN = new MetodoPagoEN ();
        metodoPagoEN.Nombre = p_nombre;

        metodoPagoEN.Tipo = p_tipo;

        //Call to MetodoPagoCAD

        oid = _IMetodoPagoCAD.New_ (metodoPagoEN);
        return oid;
}

public void Modify (int p_MetodoPago_OID, string p_nombre, TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum p_tipo)
{
        MetodoPagoEN metodoPagoEN = null;

        //Initialized MetodoPagoEN
        metodoPagoEN = new MetodoPagoEN ();
        metodoPagoEN.Id = p_MetodoPago_OID;
        metodoPagoEN.Nombre = p_nombre;
        metodoPagoEN.Tipo = p_tipo;
        //Call to MetodoPagoCAD

        _IMetodoPagoCAD.Modify (metodoPagoEN);
}

public void Destroy (int id
                     )
{
        _IMetodoPagoCAD.Destroy (id);
}

public MetodoPagoEN ReadOID (int id
                             )
{
        MetodoPagoEN metodoPagoEN = null;

        metodoPagoEN = _IMetodoPagoCAD.ReadOID (id);
        return metodoPagoEN;
}

public System.Collections.Generic.IList<MetodoPagoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MetodoPagoEN> list = null;

        list = _IMetodoPagoCAD.ReadAll (first, size);
        return list;
}
}
}
