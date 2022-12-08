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
    public class ProductoController : BasicController
    {
        // GET: Producto
        public ActionResult Index()
        {
            SessionInitialize();
            ProductoCAD prodCAD = new ProductoCAD(session);
            ProductoCEN prodCEN = new ProductoCEN(prodCAD);

            IList<ProductoEN> listEN = prodCEN.ReadAll(0, -1);
            IEnumerable<ProductoViewModel> listViewModel = new ProductoAssembler().ConvertListENToModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            IList<ProveedorEN> listaProveedores = new ProveedorCEN().ReadAll(0, -1);
            IList<SelectListItem> proveedoresItems = new List<SelectListItem>();

            foreach (ProveedorEN prov in listaProveedores)
            {
                proveedoresItems.Add(new SelectListItem { Text = prov.Nombre, Value = prov.Usuario });
            }

            ViewData["nomProveedor"] = proveedoresItems;

            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(ProductoViewModel prod)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
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

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
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
