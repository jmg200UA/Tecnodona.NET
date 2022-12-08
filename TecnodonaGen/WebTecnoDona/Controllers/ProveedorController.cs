using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecnodonaGenNHibernate.CAD.Tecnodona;
using TecnodonaGenNHibernate.CEN.Tecnodona;
using TecnodonaGenNHibernate.EN.Tecnodona;
using WebTecnoDona.Models;
using WebTecnoDona.Assemblers;

namespace WebTecnoDona.Controllers
{
    public class ProveedorController : BasicController
    {
        // GET: Proveedor
        public ActionResult Index()
        {
            SessionInitialize();
            ProveedorCAD provCAD = new ProveedorCAD(session);
            ProveedorCEN provCEN = new ProveedorCEN(provCAD);

            IList<ProveedorEN> listEN = provCEN.ReadAll(0, -1);
            IEnumerable<ProveedorViewModel> listViewModel = new ProveedorAssembler().ConvertListENToModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: Proveedor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proveedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proveedor/Create
        [HttpPost]
        public ActionResult Create(ProveedorViewModel prov)
        {
            try
            {

                ProveedorCEN provCEN = new ProveedorCEN();
                provCEN.New_(prov.usuario, prov.Nombre, prov.Contraseña, prov.Correo, prov.Telefono);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proveedor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Proveedor/Edit/5
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

        // GET: Proveedor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Proveedor/Delete/5
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
