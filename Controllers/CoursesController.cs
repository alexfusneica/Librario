using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(string id)
        {
            return View();
        }
        public IActionResult Search(string title)
        {
            return View();
        }
    }
}