
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
 * Clase MetodoPago:
 *
 */

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial class MetodoPagoCAD : BasicCAD, IMetodoPagoCAD
{
public MetodoPagoCAD() : base ()
{
}

public MetodoPagoCAD(ISession sessionAux) : base (sessionAux)
{
}



public MetodoPagoEN ReadOIDDefault (int id
                                    )
{
        MetodoPagoEN metodoPagoEN = null;

        try
        {
                SessionInitializeTransaction ();
                metodoPagoEN = (MetodoPagoEN)session.Get (typeof(MetodoPagoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return metodoPagoEN;
}

public System.Collections.Generic.IList<MetodoPagoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MetodoPagoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MetodoPagoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MetodoPagoEN>();
                        else
                                result = session.CreateCriteria (typeof(MetodoPagoEN)).List<MetodoPagoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MetodoPagoEN metodoPago)
{
        try
        {
                SessionInitializeTransaction ();
                MetodoPagoEN metodoPagoEN = (MetodoPagoEN)session.Load (typeof(MetodoPagoEN), metodoPago.Id);

                metodoPagoEN.Nombre = metodoPago.Nombre;


                metodoPagoEN.Tipo = metodoPago.Tipo;


                session.Update (metodoPagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MetodoPagoEN metodoPago)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (metodoPago);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return metodoPago.Id;
}

public void Modify (MetodoPagoEN metodoPago)
{
        try
        {
                SessionInitializeTransaction ();
                MetodoPagoEN metodoPagoEN = (MetodoPagoEN)session.Load (typeof(MetodoPagoEN), metodoPago.Id);

                metodoPagoEN.Nombre = metodoPago.Nombre;


                metodoPagoEN.Tipo = metodoPago.Tipo;

                session.Update (metodoPagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
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
                MetodoPagoEN metodoPagoEN = (MetodoPagoEN)session.Load (typeof(MetodoPagoEN), id);
                session.Delete (metodoPagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MetodoPagoEN
public MetodoPagoEN ReadOID (int id
                             )
{
        MetodoPagoEN metodoPagoEN = null;

        try
        {
                SessionInitializeTransaction ();
                metodoPagoEN = (MetodoPagoEN)session.Get (typeof(MetodoPagoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return metodoPagoEN;
}

public System.Collections.Generic.IList<MetodoPagoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MetodoPagoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MetodoPagoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MetodoPagoEN>();
                else
                        result = session.CreateCriteria (typeof(MetodoPagoEN)).List<MetodoPagoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
