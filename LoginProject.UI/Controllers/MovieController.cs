using LoginProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginProject.UI.Controllers
{
    public class MovieController : Controller
    {
        private IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieList()
        {
            var result = _movieService.GetAll();
            return View(result);
        }

        [HttpPost]
        public IActionResult SearchByFilter(string movieName)
        {
            TempData["test"] = movieName;
            var movieListByFilter = _movieService.GetByName(movieName);
            return View(movieListByFilter);
        }

    }
}
