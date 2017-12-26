using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DarkeyMiriam0.Models;

namespace DarkeyMiriam0.Controllers
{
    public class CodeStatusController : Controller
    {
        private DBDarkeyMiriamEntities db = new DBDarkeyMiriamEntities();

        // GET: CodeStatus
        public ActionResult Index()
        {
            return View(db.CodeStatus.ToList());
        }

        // GET: CodeStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeStatus codeStatus = db.CodeStatus.Find(id);
            if (codeStatus == null)
            {
                return HttpNotFound();
            }
            return View(codeStatus);
        }

        // GET: CodeStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CodeStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Status")] CodeStatus codeStatus)
        {
            if (ModelState.IsValid)
            {
                db.CodeStatus.Add(codeStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(codeStatus);
        }

        // GET: CodeStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeStatus codeStatus = db.CodeStatus.Find(id);
            if (codeStatus == null)
            {
                return HttpNotFound();
            }
            return View(codeStatus);
        }

        // POST: CodeStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Status")] CodeStatus codeStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(codeStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(codeStatus);
        }

        // GET: CodeStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeStatus codeStatus = db.CodeStatus.Find(id);
            if (codeStatus == null)
            {
                return HttpNotFound();
            }
            return View(codeStatus);
        }

        // POST: CodeStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CodeStatus codeStatus = db.CodeStatus.Find(id);
            db.CodeStatus.Remove(codeStatus);
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
