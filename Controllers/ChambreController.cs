using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using HotelGestion.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;

namespace HotelGestion.Controllers
{
    
    public class ChambreController : Controller
    {
        private Model1 db = new Model1();
        // GET: Chambre
        public JsonResult GetAll()
        {
            var chambres = db.Chambres.ToList();
            return Json(chambres, JsonRequestBehavior.AllowGet);
        }
       
        public ActionResult Index()
        {
            var item = (from d in db.Chambres
                        select d).ToList();

            return View(db.Chambres);
        }
        public ActionResult Index2()
        {
            var item = (from d in db.Chambres
                        select d).ToList();

            return View(db.Chambres);
        }

        public ActionResult ListAdmin()
        {
            var item = (from d in db.Chambres
                        select d).ToList();

            return View(db.Chambres);
        }

        public ActionResult Reserver(int? id)
        {
            Chambre c = db.Chambres.Find(id);
            return View(c);
        }

       
        public ActionResult Delete(int? id)
        {
            Reservation reservation = db.Reservations.Find(id);
            if (reservation.DateDebut.Date.Equals(DateTime.Today.AddDays(1).Date))
            {
                return RedirectToAction("MesReservation");
            }
            Chambre c = db.Chambres.Find(reservation.Chambre.Id);
            db.Reservations.Remove(reservation);
            c.Etat = false;
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Chambre c = db.Chambres.Find(id);
            return View(c);
        }
        [HttpPost]
        public ActionResult Edit(Chambre chambre, HttpPostedFileBase image1)
        {
            try
            {
                if (image1 != null)
                {
                    chambre.Image = new byte[image1.ContentLength];
                    image1.InputStream.Read(chambre.Image, 0, image1.ContentLength);
                }
                db.Entry(chambre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("../Home/Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
