

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
 *      Definition of the class ProveedorCEN
 *
 */
public partial class ProveedorCEN
{
private IProveedorCAD _IProveedorCAD;

public ProveedorCEN()
{
        this._IProveedorCAD = new ProveedorCAD ();
}

public ProveedorCEN(IProveedorCAD _IProveedorCAD)
{
        this._IProveedorCAD = _IProveedorCAD;
}

public IProveedorCAD get_IProveedorCAD ()
{
        return this._IProveedorCAD;
}

public string New_ (string p_usuario, string p_nombre, String p_pass, string p_correo, int p_telefono)
{
        ProveedorEN proveedorEN = null;
        string oid;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Usuario = p_usuario;

        proveedorEN.Nombre = p_nombre;

        proveedorEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        proveedorEN.Correo = p_correo;

        proveedorEN.Telefono = p_telefono;

        //Call to ProveedorCAD

        oid = _IProveedorCAD.New_ (proveedorEN);
        return oid;
}

public void Modify (string p_Proveedor_OID, string p_nombre, String p_pass, string p_correo, int p_telefono)
{
        ProveedorEN proveedorEN = null;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Usuario = p_Proveedor_OID;
        proveedorEN.Nombre = p_nombre;
        proveedorEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        proveedorEN.Correo = p_correo;
        proveedorEN.Telefono = p_telefono;
        //Call to ProveedorCAD

        _IProveedorCAD.Modify (proveedorEN);
}

public void Destroy (string usuario
                     )
{
        _IProveedorCAD.Destroy (usuario);
}

public ProveedorEN ReadOID (string usuario
                            )
{
        ProveedorEN proveedorEN = null;

        proveedorEN = _IProveedorCAD.ReadOID (usuario);
        return proveedorEN;
}

public System.Collections.Generic.IList<ProveedorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProveedorEN> list = null;

        list = _IProveedorCAD.ReadAll (first, size);
        return list;
}
}
}
