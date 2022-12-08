

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
 *      Definition of the class ClienteCEN
 *
 */
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string New_ (string p_usuario, string p_nombre, String p_pass, string p_correo, int p_telefono)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Usuario = p_usuario;

        clienteEN.Nombre = p_nombre;

        clienteEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        clienteEN.Correo = p_correo;

        clienteEN.Telefono = p_telefono;

        //Call to ClienteCAD

        oid = _IClienteCAD.New_ (clienteEN);
        return oid;
}

public void Modify (string p_Cliente_OID, string p_nombre, String p_pass, string p_correo, int p_telefono)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Usuario = p_Cliente_OID;
        clienteEN.Nombre = p_nombre;
        clienteEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        clienteEN.Correo = p_correo;
        clienteEN.Telefono = p_telefono;
        //Call to ClienteCAD

        _IClienteCAD.Modify (clienteEN);
}

public void Destroy (string usuario
                     )
{
        _IClienteCAD.Destroy (usuario);
}

public string Login (string p_Cliente_OID, string p_pass)
{
        string result = null;
        ClienteEN en = _IClienteCAD.ReadOIDDefault (p_Cliente_OID);

        if (en != null && en.Pass.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en.Usuario);

        return result;
}

public ClienteEN ReadOID (string usuario
                          )
{
        ClienteEN clienteEN = null;

        clienteEN = _IClienteCAD.ReadOID (usuario);
        return clienteEN;
}

public System.Collections.Generic.IList<ClienteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> list = null;

        list = _IClienteCAD.ReadAll (first, size);
        return list;
}



private string Encode (string usuario)
{
        var payload = new Dictionary<string, object>(){
                { "usuario", usuario }
        };
        string token = Jose.JWT.Encode (payload, Utils.Util.getKey (), Jose.JwsAlgorithm.HS256);

        return token;
}

public string GetToken (string usuario)
{
        ClienteEN en = _IClienteCAD.ReadOIDDefault (usuario);
        string token = Encode (en.Usuario);

        return token;
}
public string CheckToken (string token)
{
        string result = null;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                string id = (string)ObtenerUSUARIO (decodedToken);

                ClienteEN en = _IClienteCAD.ReadOIDDefault (id);

                if (en != null && ((string)en.Usuario).Equals (ObtenerUSUARIO (decodedToken))
                    ) {
                        result = id;
                }
                else throw new ModelException ("El token es incorrecto");
        } catch (Exception e)
        {
                throw new ModelException ("El token es incorrecto");
        }

        return result;
}


public string ObtenerUSUARIO (string decodedToken)
{
        try
        {
                Dictionary<string, object> results = JsonConvert.DeserializeObject<Dictionary<string, object> >(decodedToken);
                string usuario = (string)results ["usuario"];
                return usuario;
        }
        catch
        {
                throw new Exception ("El token enviado no es correcto");
        }
}
}
}
