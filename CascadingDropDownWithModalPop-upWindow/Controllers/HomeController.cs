using CascadingDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropDown.Controllers
{
    public class HomeController : Controller
    {
        CSSDropDownListDBEntities1 db = new CSSDropDownListDBEntities1();
        public ActionResult Index()
        {
            List<Student> StudentList=db.Students.ToList();
            ViewBag.StudentList = new SelectList(StudentList, "StudId", "StudName");
            return View();
        }

        public JsonResult GetStateList(int StudId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<StudentState> StudentStateList= db.StudentStates.Where(x=>x.StudId == StudId).ToList();

            return Json(StudentStateList, JsonRequestBehavior.AllowGet);
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
    }
}