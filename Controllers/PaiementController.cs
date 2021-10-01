using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelGestion.Models;

namespace HotelGestion.Controllers
{
    public class PaiementController : Controller
    {

        public Model1 db = new Model1();
        // GET: Paiement
        public ActionResult Index()
        {
            return View();
        }

        // GET: Paiement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Paiement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paiement/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Paiement p)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    db.Paiements.Add(p);
                    db.SaveChanges();

                }
                return RedirectToAction("../Home/Index");
            }
            catch
            {
                return View();
            }
        }
            

        // GET: Paiement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Paiement/Edit/5
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

        // GET: Paiement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Paiement/Delete/5
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
