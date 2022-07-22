using Microsoft.AspNetCore.Mvc;
using Le_Crystal_HW4.DAL;
using Le_Crystal_HW4.Models;
using Microsoft.EntityFrameworkCore;
//Crystal Le
//MIS 333K - Gray, Katie
//April 1, 2022
namespace Le_Crystal_HW4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
