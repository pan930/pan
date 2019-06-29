using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class AccountController : Controller
    {

        private CoursemanagerEntities db = new CoursemanagerEntities();

        //
        // GET: /Account/

         [HttpGet]
        public ActionResult Logins()
        {
            return View();
        }

         [HttpPost]
        public ActionResult Logins(string account,string password)
        {
          if (ModelState.IsValid)
            {
              var user=db.Users.FirstOrDefault(u=>u.Account==account && u.Password==password);

              if (user == null)
              {
                  return View(user);
              }

              HttpContext.Session.Add ("user",user);
               var cookie=new HttpCookie("user",user.Account)
               {
                  Expires=DateTime.Now.AddHours(3)
               };

              Response.Cookies.Add(cookie);

                return RedirectToAction("Index","Home");
            }

          return View();
        }
     }

 }

