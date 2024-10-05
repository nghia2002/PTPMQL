using Microsoft.AspNetCore.Mvc;
using MVCnew.Models;

namespace MVCnew.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            ViewBag.Student = " XIn chao " + std.Fullname + "Msv " + std.studentID + "Dia chi " + std.Address;
            return View();
        }
    }
}