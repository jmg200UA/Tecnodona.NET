using System;
using System.Collections.Generic;
namespace TecnodonaGenNHibernate.EN.Tecnodona
{
public class LineaPedidoEN_OID
{
private int id2;
public virtual int Id2 {
        get { return id2; } set { id2 = value;  }
}






public LineaPedidoEN_OID()
{
}
public LineaPedidoEN_OID(int id2)
{
        this.id2 = id2;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN_OID t = obj as LineaPedidoEN_OID;
        if (t == null)
                return false;


        if (this.id2 == t.Id2)

                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        // Su tipo es Autogenerated
        hash = hash +
               (0 == id2                                                        ? 0 : this.id2.GetHashCode ());
        return hash;
}
}
}