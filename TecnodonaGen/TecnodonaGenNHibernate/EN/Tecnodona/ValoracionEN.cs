
using System;
// Definición clase ValoracionEN
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public partial class ValoracionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo comentario
 */
private string comentario;



/**
 *	Atributo estrellas
 */
private int estrellas;



/**
 *	Atributo cliente
 */
private TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN cliente;



/**
 *	Atributo articulo
 */
private TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN articulo;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual int Estrellas {
        get { return estrellas; } set { estrellas = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN Articulo {
        get { return articulo; } set { articulo = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(int id, string comentario, int estrellas, TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN cliente, TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN articulo
                    )
{
        this.init (Id, comentario, estrellas, cliente, articulo);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id, valoracion.Comentario, valoracion.Estrellas, valoracion.Cliente, valoracion.Articulo);
}

private void init (int id
                   , string comentario, int estrellas, TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN cliente, TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN articulo)
{
        this.Id = id;


        this.Comentario = comentario;

        this.Estrellas = estrellas;

        this.Cliente = cliente;

        this.Articulo = articulo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionEN t = obj as ValoracionEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
