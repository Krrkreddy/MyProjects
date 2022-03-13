using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContactsApp;

namespace ContactsApp.Controllers
{
    public class UserRegistrationsController : Controller
    {
        private ContactsAppData db = new ContactsAppData();
       

        // GET: UserRegistrations
        public ActionResult Index()
        {
            return View(db.UserRegistrations.ToList());
        }

        // GET: UserRegistrations/SignUp
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: UserRegistrations/SignUp
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp([Bind(Include = "Email,Password,SecretCode")] UserRegistration userRegistration)
        {
            if (ModelState.IsValid)
            {
                db.UserRegistrations.Add(userRegistration);
                db.SaveChanges();
                return RedirectToAction("SignIn");
            }

            return View(userRegistration);
        }

        // GET: UserRegistrations/SignIn
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn([Bind(Include = "Email,Password")] UserRegistration userRegistration)
        {
            if (userRegistration.Email != null && userRegistration.Password != null)
            {
                var foundDetails = db.UserRegistrations.Where(x=>x.Email== userRegistration.Email && x.Password==userRegistration.Password).FirstOrDefault();
                if (foundDetails != null)
                {
                    return RedirectToAction("Create","Contacts");
                }  
                
            }
            ViewBag.Message = "Please enter valid details";
            return View();
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
