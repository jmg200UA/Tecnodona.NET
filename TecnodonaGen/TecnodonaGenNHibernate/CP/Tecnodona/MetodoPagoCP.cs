
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using TecnodonaGenNHibernate.Exceptions;
using TecnodonaGenNHibernate.EN.Tecnodona;
using TecnodonaGenNHibernate.CAD.Tecnodona;
using TecnodonaGenNHibernate.CEN.Tecnodona;



namespace TecnodonaGenNHibernate.CP.Tecnodona
{
public partial class MetodoPagoCP : BasicCP
{
public MetodoPagoCP() : base ()
{
}

public MetodoPagoCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
