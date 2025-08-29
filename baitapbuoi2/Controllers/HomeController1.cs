using Microsoft.AspNetCore.Mvc;

namespace baitapbuoi2.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Đây là trang giới thiệu.";
            return View();
        }
    }
}
