using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogTracker;
using BlogTracker.Data;

namespace BlogTracker.Controllers
{
    public class AdminInfoesController : Controller
    {
        private BlogDbContext db = new BlogDbContext();

        // GET: AdminInfoes1
        public ActionResult Index()
        {
            return View(db.AdminInfoes.ToList());
        }

        // GET: AdminInfoes1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminInfo adminInfo = db.AdminInfoes.Find(id);
            if (adminInfo == null)
            {
                return HttpNotFound();
            }
            return View(adminInfo);
        }

        // GET: AdminInfoes1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminInfoes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Email,Password")] AdminInfo adminInfo)
        {
            if (ModelState.IsValid)
            {
                db.AdminInfoes.Add(adminInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adminInfo);
        }

        // GET: AdminInfoes1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminInfo adminInfo = db.AdminInfoes.Find(id);
            if (adminInfo == null)
            {
                return HttpNotFound();
            }
            return View(adminInfo);
        }

        // POST: AdminInfoes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Email,Password")] AdminInfo adminInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminInfo);
        }

        // GET: AdminInfoes1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminInfo adminInfo = db.AdminInfoes.Find(id);
            if (adminInfo == null)
            {
                return HttpNotFound();
            }
            return View(adminInfo);
        }

        // POST: AdminInfoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AdminInfo adminInfo = db.AdminInfoes.Find(id);
            db.AdminInfoes.Remove(adminInfo);
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
