using Microsoft.AspNetCore.Mvc;

namespace Le_Crystal_HW5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
