using Microsoft.AspNetCore.Mvc;
using SessionManageMVC.Sessions;

namespace SessionManageMVC.Controllers
{
    public class StudentController : Controller
    {

        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var student = _studentService.Login(username, password);
            if (student != null)
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Welcome", "Student");
            }
            else
            {
                ViewBag.Message = "Invalid Login";
                return View();
            }
            return View();
        }
        public IActionResult Welcome()
        {
            ViewBag.Message = "Success Login";
            ViewBag.Message2 = HttpContext.Session.GetString("username");
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index", "Student");
        }

    }
}
