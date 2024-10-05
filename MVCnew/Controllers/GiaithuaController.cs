using Microsoft.AspNetCore.Mvc;

namespace MVCnew.Controllers
{
    public class GiaithuaController : Controller
    {
        public ActionResult ABC(){
            return View();
        }
        [HttpPost]
        public ActionResult ABC(int n)
        {
            int ketqua = 1;
            for (int i = 1; i <= n; i++){
                ketqua = ketqua * i;
            }
              ViewBag.ketqua= "Ket qua cua n! la :" + ketqua;
              return View();
        }
    }
}