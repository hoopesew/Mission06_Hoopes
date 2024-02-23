using Microsoft.AspNetCore.Mvc;
using Mission06_Hoopes.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission06_Hoopes.Controllers
{
    public class HomeController : Controller
    {
        private MovieSubmissionContext _context;

        public HomeController(MovieSubmissionContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFilms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFilms(MovieSubmission response)
        {
            _context.AddFilms.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
