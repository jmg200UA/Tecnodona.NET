using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecnodonaGenNHibernate.CAD.Tecnodona;
using TecnodonaGenNHibernate.CEN.Tecnodona;
using TecnodonaGenNHibernate.EN.Tecnodona;
using WebTecnoDona.Assemblers;
using WebTecnoDona.Models;

namespace WebTecnoDona.Controllers
{
    public class MetodoPagoController : BasicController
    {
        // GET: MetodoPago
        public ActionResult Index()
        {
            SessionInitialize();

            MetodoPagoCAD pagoCAD = new MetodoPagoCAD(session);
            MetodoPagoCEN pagoCEN = new MetodoPagoCEN(pagoCAD);

            IList<MetodoPagoEN> listEN = pagoCEN.ReadAll(0, -1);
            IEnumerable<MetodoPagoViewModel> listViewModel = new MetodoPagoAssembler().ConvertListENToModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: MetodoPago/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MetodoPago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MetodoPago/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MetodoPago/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MetodoPago/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MetodoPago/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MetodoPago/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
