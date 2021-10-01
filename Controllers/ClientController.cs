using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelGestion.Models;

namespace HotelGestion.Controllers
{
    public class ClientController : Controller
    {
        private Model1 db = new Model1();
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Client client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    db.Clients.Add(client);
                    User u = new User
                    {
                        Login = client.email,
                        Pwd = CommonMethods.ConvertToEncrypt(client.Passwd),
                        UserRole = db.Roles.Find(2)
                    };
                    db.Users.Add(u);
                    db.SaveChanges();
                    
                }
                return RedirectToAction("../Home/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
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

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
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
