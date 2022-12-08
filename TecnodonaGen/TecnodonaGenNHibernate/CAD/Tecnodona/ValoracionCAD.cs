
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
 * Clase Valoracion:
 *
 */

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial class ValoracionCAD : BasicCAD, IValoracionCAD
{
public ValoracionCAD() : base ()
{
}

public ValoracionCAD(ISession sessionAux) : base (sessionAux)
{
}



public ValoracionEN ReadOIDDefault (int id
                                    )
{
        ValoracionEN valoracionEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionEN = (ValoracionEN)session.Get (typeof(ValoracionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionEN;
}

public System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ValoracionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ValoracionEN>();
                        else
                                result = session.CreateCriteria (typeof(ValoracionEN)).List<ValoracionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ValoracionEN valoracion)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionEN valoracionEN = (ValoracionEN)session.Load (typeof(ValoracionEN), valoracion.Id);

                valoracionEN.Comentario = valoracion.Comentario;


                valoracionEN.Estrellas = valoracion.Estrellas;



                session.Update (valoracionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ValoracionEN valoracion)
{
        try
        {
                SessionInitializeTransaction ();
                if (valoracion.Cliente != null) {
                        // Argumento OID y no colección.
                        valoracion.Cliente = (TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN)session.Load (typeof(TecnodonaGenNHibernate.EN.Tecnodona.ClienteEN), valoracion.Cliente.Usuario);

                        valoracion.Cliente.Valoracion
                        .Add (valoracion);
                }
                if (valoracion.Articulo != null) {
                        // Argumento OID y no colección.
                        valoracion.Articulo = (TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN)session.Load (typeof(TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN), valoracion.Articulo.Id);

                        valoracion.Articulo.Valoracion
                                = valoracion;
                }

                session.Save (valoracion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracion.Id;
}

public void Modify (ValoracionEN valoracion)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionEN valoracionEN = (ValoracionEN)session.Load (typeof(ValoracionEN), valoracion.Id);

                valoracionEN.Comentario = valoracion.Comentario;


                valoracionEN.Estrellas = valoracion.Estrellas;

                session.Update (valoracionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
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
                ValoracionEN valoracionEN = (ValoracionEN)session.Load (typeof(ValoracionEN), id);
                session.Delete (valoracionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ValoracionEN
public ValoracionEN ReadOID (int id
                             )
{
        ValoracionEN valoracionEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionEN = (ValoracionEN)session.Get (typeof(ValoracionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionEN;
}

public System.Collections.Generic.IList<ValoracionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ValoracionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ValoracionEN>();
                else
                        result = session.CreateCriteria (typeof(ValoracionEN)).List<ValoracionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
