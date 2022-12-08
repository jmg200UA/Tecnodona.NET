
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
public partial class FacturaCP : BasicCP
{
public FacturaCP() : base ()
{
}

public FacturaCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
