using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheLastOfUs.Models;

namespace TheLastOfUs.Controllers
{
    public class SafeHavensController : Controller
    {
        private TheLastOfUsContext db = new TheLastOfUsContext();

        // GET: SafeHavens
        public ActionResult Index()
        {
            return View(db.SafeHavens.ToList());
        }

        // GET: SafeHavens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SafeHaven safeHaven = db.SafeHavens.Find(id);
            if (safeHaven == null)
            {
                return HttpNotFound();
            }
            return View(safeHaven);
        }

        // GET: SafeHavens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SafeHavens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] SafeHaven safeHaven)
        {
            if (ModelState.IsValid)
            {
                db.SafeHavens.Add(safeHaven);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(safeHaven);
        }

        // GET: SafeHavens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SafeHaven safeHaven = db.SafeHavens.Find(id);
            if (safeHaven == null)
            {
                return HttpNotFound();
            }
            return View(safeHaven);
        }

        // POST: SafeHavens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] SafeHaven safeHaven)
        {
            if (ModelState.IsValid)
            {
                db.Entry(safeHaven).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(safeHaven);
        }

        // GET: SafeHavens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SafeHaven safeHaven = db.SafeHavens.Find(id);
            if (safeHaven == null)
            {
                return HttpNotFound();
            }
            return View(safeHaven);
        }

        // POST: SafeHavens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SafeHaven safeHaven = db.SafeHavens.Find(id);
            db.SafeHavens.Remove(safeHaven);
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
