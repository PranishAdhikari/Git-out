using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers
{
    public class JSONController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetJson()
        {
            string output = false ? "Pranish Adhikari" : "Pranish Adhikari";

            return Json(output);
        }
    }
}
