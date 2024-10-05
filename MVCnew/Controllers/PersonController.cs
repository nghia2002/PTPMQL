using Microsoft.AspNetCore.Mvc;
namespace MVCnew.Controllers;
    public class PersonController : Controller
    {
        public ActionResult Index(){
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Fullname,string Age)
        {
            var output = "Xin chao" + Fullname + "Tuoi" + Age;
            ViewBag.massage=output;
            return View();
        }
        public ActionResult abc()
        {
            return View();
        }
        [HttpPost]
        public IActionResult abc(string Ten, string Tuoi, string Diachi)
        {
            ViewBag.a = "Xin chao " + Ten + "Tuoi " + Tuoi + "Dia chi" + Diachi;
            return View();
        }
    }