using Exam.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Entity entity = new Entity();
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult ToRegister(string StudentNumber, string Password)
        {
            var st = entity.Student;
            var result = st.FirstOrDefault(p => p.StudentNumber == StudentNumber);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ToLogin(string StudentNumber, string Password)
        {
            var st = entity.Student;
            var result = st.FirstOrDefault(p => p.StudentNumber == StudentNumber);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult q()
        {
            return View();
        }
        //public ActionResult To(string a,string b)
        //{
        //    if(a == "1")
        //    {
        //        return Redirect("/Login/Login");
        //    }else {
        //        return Redirect("/Login/q");
        //    }            
        //}
        public ActionResult To()
        {
            if (HttpContext.Request["a"] == HttpContext.Request["b"])
            {
                return Redirect("/Login/Login");
            }
            else
            {
                return Redirect("/Login/q");
            }
        }
    }


    public class qwe
    {
        public string a { get; set; }
        public void rty()
        {
            return;
        }
    }
}