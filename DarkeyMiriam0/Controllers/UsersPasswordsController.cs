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
    public class UsersPasswordsController : Controller
    {
        private DBDarkeyMiriamEntities db = new DBDarkeyMiriamEntities();

        // GET: UsersPasswords
        public ActionResult Index()
        {
            using (var db1 = new DBDarkeyMiriamEntities())
            {
                db1.Configuration.ProxyCreationEnabled = false;
                List<UsersVM> av = new List<UsersVM>();
                var users = db1.UsersPassword.Include(u => u.CodeStatus1);
                foreach (var t in users)
                {
                    var user = new UsersVM();
                    user.CodeSta = t.CodeStatus1.Code;
                    user.IdSta = t.CodeStatus1.Id;
                    user.NameUs = t.Name;
                    user.IdUs = t.Id;
                    user.PasswordUs = t.Password;
                    user.StatusSta = t.CodeStatus1.Status;
                    user.CodeStatusUs = t.CodeStatus;
                    av.Add(user);
                }
                return View(av.ToList());
            }
            }

        // GET: UsersPasswords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsersPassword usersPassword = db.UsersPassword.Find(id);
            if (usersPassword == null)
            {
                return HttpNotFound();
            }
            return View(usersPassword);
        }

        // GET: UsersPasswords/Create
        public ActionResult Create()
        {
            ViewBag.CodeStatus = new SelectList(db.CodeStatus, "Id", "Status");
            return View();
        }

        // POST: UsersPasswords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Password,CodeStatus")] UsersPassword usersPassword)
        {
            if (ModelState.IsValid)
            {
                db.UsersPassword.Add(usersPassword);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CodeStatus = new SelectList(db.CodeStatus, "Id", "Status", usersPassword.CodeStatus);
            return View(usersPassword);
        }

        // GET: UsersPasswords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsersPassword usersPassword = db.UsersPassword.Find(id);
            if (usersPassword == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodeStatus = new SelectList(db.CodeStatus, "Id", "Status", usersPassword.CodeStatus);
            return View(usersPassword);
        }

        // POST: UsersPasswords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Password,CodeStatus")] UsersPassword usersPassword)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usersPassword).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CodeStatus = new SelectList(db.CodeStatus, "Id", "Status", usersPassword.CodeStatus);
            return View(usersPassword);
        }

        // GET: UsersPasswords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsersPassword usersPassword = db.UsersPassword.Find(id);
            if (usersPassword == null)
            {
                return HttpNotFound();
            }
            return View(usersPassword);
        }

        // POST: UsersPasswords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsersPassword usersPassword = db.UsersPassword.Find(id);
            db.UsersPassword.Remove(usersPassword);
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
