using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity;
using System.Net;
using HotelGestion.Models;

namespace HotelGestion.Controllers
{
    public class UserController : Controller
    {
        private Model1 db = new Model1();
        // GET: User

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(db.Users);
        }

        // GET: User/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login( User model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    foreach (var item in db.Users)
                    {

                        if (item.Login == model.Login && CommonMethods.ConvertToDescrypt(item.Pwd) == model.Pwd)
                        {
                            
                            FormsAuthentication.SetAuthCookie(item.Login, false);
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    ModelState.AddModelError("err0", "Login ou password incorrect");
                 
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
