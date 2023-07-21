using ForgeryTokensMVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ForgeryTokensMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(StudentModel student)
        {
            int studentId = student.StudentId;
            string studentName = student.StudentName;
            string studentCity = student.StudentCity;
            string studentGender = student.StudentGender;
            return View();
        }

        [ChildActionOnly]
        public ActionResult StudentDetails(List<string> studentlist)
        {
            return View(studentlist);
        }
    }
}