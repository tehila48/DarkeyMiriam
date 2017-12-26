using DarkeyMiriam0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace DarkeyMiriam0.Controllers
{
    public class HomeController : Controller
    {
        private DBDarkeyMiriamEntities db = new DBDarkeyMiriamEntities();
       
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Logino(string username, string password)
        {
          
            //ViewBag.ReturnUrl = returnUrl;
            var users = db.UsersPassword.Include(u => u.CodeStatus1);
            var vol = db.Volunteer;
            var pat = db.Patient;
            //ViewBag.Status = 1111;
            foreach (var u in users)
            {
                if ((u.Password == password) && (u.Name == username))
                {
                    Session["Status"] = u.CodeStatus;
                    if (u.CodeStatus == 1111)
                    {
                        var name = username;
                        Session["theID"] = db.Volunteer.ToList().Find(x => x.Name == name).Id;
                        Session["name1"] = username;
                    }
                    if (u.CodeStatus == 2222)
                    {
                        var name = username;
                        Session["theID"] = db.Patient.ToList().Find(x => x.Name == name).Id;                          
                        Session["name1"] = username;
                    }

                }
               


            }
            return View("Index");
        }
    }
}