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
    public class ArticuloController : BasicController
    {
        // GET: Articulo
        public ActionResult Index()
        {
            SessionInitialize();
            ArticuloCAD artCAD = new ArticuloCAD(session);
            ArticuloCEN artCEN = new ArticuloCEN(artCAD);

            IList<ArticuloEN> listEN = artCEN.ReadAll(0, -1);
            IEnumerable<ArticuloViewModel> listViewModel = new ArticuloAssembler().ConvertListENToModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: Articulo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Articulo/Create
        public ActionResult Create()
        {
            IList<ProveedorEN> listaProveedores = new ProveedorCEN().ReadAll(0, -1);
            IList<SelectListItem> proveedoresItems = new List<SelectListItem>();

            foreach (ProveedorEN prov in listaProveedores) {
                proveedoresItems.Add(new SelectListItem { Text = prov.Nombre, Value = prov.Usuario });
            }

            ViewData["nomProveedor"] = proveedoresItems;

            IList<ProductoEN> listaProductos = new ProductoCEN().ReadAll(0, -1);
            IList<SelectListItem> productosItems = new List<SelectListItem>();

            foreach (ProductoEN prod in listaProductos)
            {
                productosItems.Add(new SelectListItem { Text = prod.NumeroReferencia.ToString() , Value = prod.NumeroReferencia.ToString() });
            }

            ViewData["IdProducto"] = productosItems;

            return View();
        }

        // POST: Articulo/Create
        [HttpPost]
        public ActionResult Create(ArticuloViewModel art)
        {
            try
            {
                ArticuloCEN artCEN = new ArticuloCEN();
                artCEN.New_(art.Nombre, art.Precio, art.Descripcion, art.nomProveedor, art.IdProducto, true);

                //int articulo1 = articulo.New_("PS5", 400, "Consola ultima generacion", proveedor1, producto1, true);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Articulo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Articulo/Edit/5
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

        // GET: Articulo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Articulo/Delete/5
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
