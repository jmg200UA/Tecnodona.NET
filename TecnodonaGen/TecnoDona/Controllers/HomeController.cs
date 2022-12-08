using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecnodonaGenNHibernate.EN.Tecnodona;
using TecnodonaGenNHibernate.CEN.Tecnodona;


namespace TecnoDona.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ArticuloCEN artCEN = new ArticuloCEN();
            IEnumerable<ArticuloEN> listaArt = artCEN.ReadAll(0, -1).ToList();
            return View(listaArt);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}