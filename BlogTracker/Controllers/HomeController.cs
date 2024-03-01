using BlogTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogTracker.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(AdminInfo sign)
        {
            if (ModelState.IsValid)
            {

                if ((sign.Email == "banala@gmail.com") && (sign.Password == "banala@!23"))
                {

                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("Index", "EmpInfoes", new { Layout = "~/Views/Shared/Employee_Layout.cshtml" });
                }
                else
                {
                    ModelState.AddModelError("", "Either User Name or Password Incorrect!!!");
                    return View(sign);

                }
            }
            else
            {
                return View(sign);
            }
        }
            public ActionResult AdminFail()
        {
            return View();
        }
        
        public ActionResult EmpLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmpLogin(EmpInfo sign)
        {
            BlogDbContext db = new BlogDbContext();

            if ((sign.Email == "ramya@gmail.com") && (sign.PassCode == 47955))
            {

                Session["UserId"] = Guid.NewGuid();
                return RedirectToAction("Index", "BlogInfoes", new { Layout = "~/Views/Shared/Admin_Layout.cshtml" });
            }
            else
            {
                ModelState.AddModelError("", "Either User Name or Password Incorrect!!!");
                return View(sign);

            }
        }
            
       public ActionResult EmpFail()
        {
            return View();
        }

    }
}