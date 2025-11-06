using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RezervacniSystem.Models;

namespace RezervacniSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pokoje()
        {
            return View();
        }

        public IActionResult Aktivity()
        {
            return View();
        }
        public IActionResult Wellness()
        {
            return View();
        }
        public IActionResult Kontakt()
        {
            return View();
        }
        public IActionResult Rezervace()
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
