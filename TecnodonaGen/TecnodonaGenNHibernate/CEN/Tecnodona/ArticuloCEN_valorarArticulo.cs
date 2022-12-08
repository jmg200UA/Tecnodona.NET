
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using TecnodonaGenNHibernate.Exceptions;
using TecnodonaGenNHibernate.EN.Tecnodona;
using TecnodonaGenNHibernate.CAD.Tecnodona;


/*PROTECTED REGION ID(usingTecnodonaGenNHibernate.CEN.Tecnodona_Articulo_valorarArticulo) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TecnodonaGenNHibernate.CEN.Tecnodona
{
public partial class ArticuloCEN
{
public TecnodonaGenNHibernate.EN.Tecnodona.ArticuloEN ValorarArticulo (int p_id, int p_id_val, int nueva_valoracion)
{
        /*PROTECTED REGION ID(TecnodonaGenNHibernate.CEN.Tecnodona_Articulo_valorarArticulo) ENABLED START*/

        // Write here your custom code...
        ArticuloEN artEN = _IArticuloCAD.ReadOIDDefault (p_id);

        //artEN = ArticuloCEN.ReadOID(articulo1); //Si no se ha definido ReadOID en OOH4RIA, se hace new ArticuloCAD().ReadOIDDefault(articulo1)
        //ValoracionEN valEN = artEN.Valoracion;

        if (nueva_valoracion >= 0 && nueva_valoracion <= 5) {
                artEN.Valoracion.Estrellas = nueva_valoracion;
                _IArticuloCAD.Modify (artEN);
                //throw new ModelException ("Valoracion del articulo#" + artEN.Id + " se ha actualizado");
        }
        else{
                throw new ModelException ("Valoracion del articulo#" + artEN.Id + " no se ha podido actualizar");
        }
        return artEN;

        /*PROTECTED REGION END*/
}
}
}
