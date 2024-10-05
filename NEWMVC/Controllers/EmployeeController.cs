using Microsoft.AspNetCore.Mvc;
using NEWMVC.Models;

namespace NEWMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee epl)
        {
            ViewBag.send= "Xin chao " + epl.Fullname + " Ma nhan vien : " + epl.EmployeeID + "So dien thoai " + epl.Phonenumber;
            return View();
        }
    }
}