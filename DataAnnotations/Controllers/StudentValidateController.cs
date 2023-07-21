using DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotations.Controllers
{
    public class StudentValidateController : Controller
    {
        // GET: StudentValidate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(StudentValidate sv)
        {
            return View();
        }
    }
}