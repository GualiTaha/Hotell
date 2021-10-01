using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Drawing;
using HotelGestion.Models;
using System.IO;

namespace HotelGestion.Controllers
{
    public class AdminController : Controller
    {
        private Model1 db = new Model1();
        public ActionResult Index()
        {
            return View(db.Reservations);
        }

        public ActionResult AddChambre()
        {
            Chambre c = new Chambre();
            return View(c);
        }

        [HttpPost]
        public ActionResult AddChambre( Chambre chambre, HttpPostedFileBase image1)
        {
            if (ModelState.IsValid)
            {
                if(image1 != null)
                {
                    chambre.Image = new byte[image1.ContentLength];
                    image1.InputStream.Read(chambre.Image, 0, image1.ContentLength);
                }
                chambre.Etat = false;
                db.Chambres.Add(chambre);
                db.SaveChanges();
                  return RedirectToAction("../Home/Index");
            }
            else
            {
                return View();
            }
        }
    }
}