using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace DEMOMVC.Controllers
{
        public class PersonController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        
        [HttpPost]
        public IActionResult Index(string Fullname, string Address, string PersonID)
        {
            ViewBag.Message = "Xin chào " + Fullname + " Đến từ" + Address + " ID là :" + PersonID;
            return View();
        }
        }
}