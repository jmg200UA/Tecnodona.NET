
using System;
using System.Text;
using TecnodonaGenNHibernate.CEN.Tecnodona;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using TecnodonaGenNHibernate.EN.Tecnodona;
using TecnodonaGenNHibernate.Exceptions;


/*
 * Clase Articulo:
 *
 */

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial class ArticuloCAD : BasicCAD, IArticuloCAD
{
public ArticuloCAD() : base ()
{
}

public ArticuloCAD(ISession sessionAux) : base (sessionAux)
{
}



public ArticuloEN ReadOIDDefault (int id
                                  )
{
        ArticuloEN articuloEN = null;

        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Get (typeof(ArticuloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ArticuloEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ArticuloEN>();
                        else
                                result = session.CreateCriteria (typeof(ArticuloEN)).List<ArticuloEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), articulo.Id);

                articuloEN.Nombre = articulo.Nombre;


                articuloEN.Precio = articulo.Precio;


                articuloEN.Descripcion = articulo.Descripcion;






                articuloEN.Disponible = articulo.Disponible;

                session.Update (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                if (articulo.Proveedor != null) {
                        // Argumento OID y no colección.
                        articulo.Proveedor = (TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN)session.Load (typeof(TecnodonaGenNHibernate.EN.Tecnodona.ProveedorEN), articulo.Proveedor.Usuario);

                        articulo.Proveedor.Articulo
                        .Add (articulo);
                }
                if (articulo.Producto != null) {
                        // Argumento OID y no colección.
                        articulo.Producto = (TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN)session.Load (typeof(TecnodonaGenNHibernate.EN.Tecnodona.ProductoEN), articulo.Producto.NumeroReferencia);

                        articulo.Producto.Articulo
                        .Add (articulo);
                }

                session.Save (articulo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articulo.Id;
}

public void Modify (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), articulo.Id);

                articuloEN.Nombre = articulo.Nombre;


                articuloEN.Precio = articulo.Precio;


                articuloEN.Descripcion = articulo.Descripcion;


                articuloEN.Disponible = articulo.Disponible;

                session.Update (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), id);
                session.Delete (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ArticuloEN
public ArticuloEN ReadOID (int id
                           )
{
        ArticuloEN articuloEN = null;

        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Get (typeof(ArticuloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ArticuloEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ArticuloEN>();
                else
                        result = session.CreateCriteria (typeof(ArticuloEN)).List<ArticuloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
