
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
 * Clase Proveedor:
 *
 */

namespace TecnodonaGenNHibernate.CAD.Tecnodona
{
public partial class ProveedorCAD : BasicCAD, IProveedorCAD
{
public ProveedorCAD() : base ()
{
}

public ProveedorCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProveedorEN ReadOIDDefault (string usuario
                                   )
{
        ProveedorEN proveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                proveedorEN = (ProveedorEN)session.Get (typeof(ProveedorEN), usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proveedorEN;
}

public System.Collections.Generic.IList<ProveedorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ProveedorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProveedorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProveedorEN>();
                        else
                                result = session.CreateCriteria (typeof(ProveedorEN)).List<ProveedorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ProveedorEN proveedor)
{
        try
        {
                SessionInitializeTransaction ();
                ProveedorEN proveedorEN = (ProveedorEN)session.Load (typeof(ProveedorEN), proveedor.Usuario);


                session.Update (proveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (ProveedorEN proveedor)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (proveedor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proveedor.Usuario;
}

public void Modify (ProveedorEN proveedor)
{
        try
        {
                SessionInitializeTransaction ();
                ProveedorEN proveedorEN = (ProveedorEN)session.Load (typeof(ProveedorEN), proveedor.Usuario);

                proveedorEN.Nombre = proveedor.Nombre;


                proveedorEN.Pass = proveedor.Pass;


                proveedorEN.Correo = proveedor.Correo;


                proveedorEN.Telefono = proveedor.Telefono;

                session.Update (proveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string usuario
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ProveedorEN proveedorEN = (ProveedorEN)session.Load (typeof(ProveedorEN), usuario);
                session.Delete (proveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ProveedorEN
public ProveedorEN ReadOID (string usuario
                            )
{
        ProveedorEN proveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                proveedorEN = (ProveedorEN)session.Get (typeof(ProveedorEN), usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proveedorEN;
}

public System.Collections.Generic.IList<ProveedorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProveedorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProveedorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProveedorEN>();
                else
                        result = session.CreateCriteria (typeof(ProveedorEN)).List<ProveedorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TecnodonaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TecnodonaGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
