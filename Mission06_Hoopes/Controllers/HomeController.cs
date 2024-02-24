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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View(new MovieSub());
        }

        [HttpPost]
        public IActionResult AddFilms(MovieSub response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }


        public IActionResult MoviesTable()
        {
            var movies = _context.Movies //i need to fix this! I need it to be MoviesTable
                 .OrderBy(x => x.Category).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("AddFilms", recordEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieSub updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MoviesTable");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordDelete);
        }

        [HttpPost]
        public IActionResult Delete(MovieSub appID)
        {
            _context.Movies.Remove(appID);
            _context.SaveChanges();

            return RedirectToAction("MoviesTable");
        }
    }
}
