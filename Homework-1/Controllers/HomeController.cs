using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Le_Crystal_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/LeCrystal_Resume_2022.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "LeCrystal_Resume_2022.pdf");
        }

        public IActionResult FoodieCorner()
        {
            return View();
        }

        public IActionResult Spotify()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
