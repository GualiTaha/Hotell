using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelGestion.Models;

namespace HotelGestion.Controllers
{
    public class ReservationController : Controller
    {

        public Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Index1()
        {
            var item = (from d in db.Chambres
                        select d).ToList();

            return View(db.Chambres);
        }
        public ActionResult Index2()
        {
            var item = (from d in db.
                        Reservations
                        select d).ToList();

            return View(db.Reservations);

        }

        // GET: Reservation/Create
        public ActionResult Create(int? id)
        {
            Chambre c = db.Chambres.Find(id);
            return View(c);
        }

        // POST: Reservation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Chambre chambre)
        {
          
                Client c = db.Clients.FirstOrDefault(item => item.email == User.Identity.Name);
                Reservation r = new Reservation
                {
                    Chambre = db.Chambres.Find(chambre.Id),
                    NbrJour = int.Parse(collection["jours"]),
                    DateDebut = DateTime.Parse(collection["dateP"]),
                     
                };
                int res = int.Parse(collection["jours"]) * r.Chambre.Prix;
                 DateTime dt = new DateTime();
                 r.DateFin = r.DateDebut.AddDays(r.NbrJour);
                r.Price = res;
                r.Chambre.Etat = true;
                c.Reservations.Add(r);
                db.SaveChanges();
           
                return RedirectToAction("/../Paiement/Create");
       
        }

        // GET: Reservation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservation/Edit/5
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

        // GET: Reservation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservation/Delete/5
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
