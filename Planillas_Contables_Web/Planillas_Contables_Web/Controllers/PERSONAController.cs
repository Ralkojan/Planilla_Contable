using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NEGOCIO;
using ENTITIES;
using System.Net;


namespace Planillas_Contables_Web.Controllers
{
    public class PERSONAController : Controller
    {
        N_PERSONA SrvPersona = new N_PERSONA();
        // GET: Personas
        public ActionResult Index()
        {
            List<E_PERSONA> persona = new List<E_PERSONA>();
            persona = SrvPersona.ListaPersona().ToList();
            return View(persona);


        }

        // GET: PERSONA/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PERSONA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PERSONA/Create
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

        // GET: PERSONA/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PERSONA/Edit/5
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

        // GET: PERSONA/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PERSONA/Delete/5
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
