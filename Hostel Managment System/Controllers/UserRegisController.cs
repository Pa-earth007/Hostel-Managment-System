using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hostel_Managment_System.Models;

namespace Hostel_Managment_System.Controllers
{
    public class UserRegisController : Controller
    {
        private DatabaseEntities db = new DatabaseEntities();

        // GET: UserRegis
        public ActionResult Index()
        {
            var userRegis = db.UserRegis.Include(u => u.Profile_Info);
            return View(userRegis.ToList());
        }

        // GET: UserRegis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRegi userRegi = db.UserRegis.Find(id);
            if (userRegi == null)
            {
                return HttpNotFound();
            }
            return View(userRegi);
        }

        // GET: UserRegis/Create
        public ActionResult Create()
        {
            ViewBag.User_Id = new SelectList(db.Profile_Info, "Profile_Id", "Profile_Id");
            return View();
        }

        // POST: UserRegis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "User_Id,Name,DOB,Address,Email,ContactNo,YOS")] UserRegi userRegi)
        {
            if (ModelState.IsValid)
            {
                db.UserRegis.Add(userRegi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.User_Id = new SelectList(db.Profile_Info, "Profile_Id", "Profile_Id", userRegi.User_Id);
            return View(userRegi);
        }

        // GET: UserRegis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRegi userRegi = db.UserRegis.Find(id);
            if (userRegi == null)
            {
                return HttpNotFound();
            }
            ViewBag.User_Id = new SelectList(db.Profile_Info, "Profile_Id", "Profile_Id", userRegi.User_Id);
            return View(userRegi);
        }

        // POST: UserRegis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "User_Id,Name,DOB,Address,Email,ContactNo,YOS")] UserRegi userRegi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userRegi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.User_Id = new SelectList(db.Profile_Info, "Profile_Id", "Profile_Id", userRegi.User_Id);
            //return View(userRegi);
        }

        // GET: UserRegis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRegi userRegi = db.UserRegis.Find(id);
            if (userRegi == null)
            {
                return HttpNotFound();
            }
            return View(userRegi);
        }

        // POST: UserRegis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRegi userRegi = db.UserRegis.Find(id);
            db.UserRegis.Remove(userRegi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
