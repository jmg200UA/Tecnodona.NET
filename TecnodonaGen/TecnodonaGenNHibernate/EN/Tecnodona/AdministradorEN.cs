
using System;
// Definición clase AdministradorEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class AdministradorEN                                                                        : TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN


{
public AdministradorEN() : base ()
{
}



public AdministradorEN(string usuario,
                       string nombre, String pass, string correo, int telefono, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN> valoracion
                       )
{
        this.init (Usuario, nombre, pass, correo, telefono, pedido, valoracion);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (Usuario, administrador.Nombre, administrador.Pass, administrador.Correo, administrador.Telefono, administrador.Pedido, administrador.Valoracion);
}

private void init (string usuario
                   , string nombre, String pass, string correo, int telefono, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN> valoracion)
{
        this.Usuario = usuario;


        this.Nombre = nombre;

        this.Pass = pass;

        this.Correo = correo;

        this.Telefono = telefono;

        this.Pedido = pedido;

        this.Valoracion = valoracion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministradorEN t = obj as AdministradorEN;
        if (t == null)
                return false;
        if (Usuario.Equals (t.Usuario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Usuario.GetHashCode ();
        return hash;
}
}
}
