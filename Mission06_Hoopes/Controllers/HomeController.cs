using Microsoft.AspNetCore.Mvc;
using Mission06_Hoopes.Models;
using System.Diagnostics;

namespace Mission06_Hoopes.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddFilms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSubmission(MovieSubmission response)
        {
            return View("Confirmation", response);
        }
    }
}
