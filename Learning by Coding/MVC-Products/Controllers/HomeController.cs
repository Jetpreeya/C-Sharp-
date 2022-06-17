using Microsoft.AspNetCore.Mvc;
using MVC_13062022.Models;
using System.Diagnostics;

namespace MVC_13062022.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // localhost:1111/home/index
        public IActionResult Index()
        {
            return View();
        }

        //localhost:1111/home/privacy
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}