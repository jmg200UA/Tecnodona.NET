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
    public class ValoracionController : BasicController
    {
        // GET: Valoracion
        public ActionResult Index()
        {
            SessionInitialize();
            ValoracionCAD valCAD = new ValoracionCAD(session);
            ValoracionCEN valCEN = new ValoracionCEN(valCAD);

            IList<ValoracionEN> listEN = valCEN.ReadAll(0, -1);
            IEnumerable<ValoracionViewModel> listViewModel = new ValoracionAssembler().ConvertListENToModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: Valoracion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Valoracion/Create
        public ActionResult Create()
        {
            IList<ClienteEN> listaClientes = new ClienteCEN().ReadAll(0, -1);
            IList<SelectListItem> clientesItems = new List<SelectListItem>();

            foreach (ClienteEN cli in listaClientes)
            {
                clientesItems.Add(new SelectListItem { Text = cli.Nombre, Value = cli.Usuario });
            }

            ViewData["nomCliente"] = clientesItems;

            IList<ArticuloEN> listaArticulos = new ArticuloCEN().ReadAll(0, -1);
            IList<SelectListItem> articulosItems = new List<SelectListItem>();

            foreach (ArticuloEN art in listaArticulos)
            {
                articulosItems.Add(new SelectListItem { Text = art.Nombre, Value = art.Id.ToString() });
            }

            ViewData["IdArticulo"] = articulosItems;

            return View();
        }

        // POST: Valoracion/Create
        [HttpPost]
        public ActionResult Create(ValoracionViewModel val)
        {
            try
            {
                ValoracionCEN valCEN = new ValoracionCEN();
                valCEN.New_(val.Comentario, val.Estrellas, val.nomCliente, val.IdArticulo);

                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Valoracion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Valoracion/Edit/5
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

        // GET: Valoracion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Valoracion/Delete/5
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
