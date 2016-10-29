using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MyPages.Models;
using MyPages.ViewModels;
using System.Data.Entity;

namespace MyPages.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id); ;

            if (movies == null)
                return HttpNotFound();
            return View(movies);
        }




        //PRACTICE
        // question mark HERE means this parameter is igornable, 
        // string type in C# is igornable, so no question MARK for string
        // dynamic route that created in RouteConfig.cs
        // :regex followed the parameter is a regular expression that may set constraints.
        // see more constraints by google "ASP.NET MVC Attribnute Route Constraints.
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "-" + month);
        }

        public ActionResult New()
        {
            var genre = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Genres = genre,
                NewMovie = true
            };
            return View("MovieForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            { 
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseTime = movie.ReleaseTime;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = _context.Genres.ToList(),
                NewMovie = false
            };
            return View("MovieForm", viewModel);
        }


    }
}