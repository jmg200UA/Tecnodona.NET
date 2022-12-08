
using System;
// Definición clase ClienteEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class ClienteEN
{
/**
 *	Atributo usuario
 */
private string usuario;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo correo
 */
private string correo;



/**
 *	Atributo telefono
 */
private int telefono;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN> valoracion;






public virtual string Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual string Correo {
        get { return correo; } set { correo = value;  }
}



public virtual int Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}





public ClienteEN()
{
        pedido = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN>();
        valoracion = new System.Collections.Generic.List<TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN>();
}



public ClienteEN(string usuario, string nombre, String pass, string correo, int telefono, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.PedidoEN> pedido, System.Collections.Generic.IList<TecnodonaGenNHibernate.EN.Tecnodona.ValoracionEN> valoracion
                 )
{
        this.init (Usuario, nombre, pass, correo, telefono, pedido, valoracion);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (Usuario, cliente.Nombre, cliente.Pass, cliente.Correo, cliente.Telefono, cliente.Pedido, cliente.Valoracion);
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
        ClienteEN t = obj as ClienteEN;
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
