using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie{Id = 1,Name = "Shrek"},
            new Movie{Id=2,Name="Final Destination"},
            new Movie{Id=3,Name="Pink Panther"}

        };
        public IActionResult Movies()
        {


            return View(movies);


        }
        public IActionResult MovieInfo(int id)
        {

            var movie = movies.Find(e => e.Id == id);
            return View(movie);


        }
        //GET: Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            { new Customer{Name = "Customer 1"},
              new Customer{Name ="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            return View(viewModel);
        }



        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}
        //[Route("[controller]/released/{year}/{month:regex(^\\d{{2}}$)}")]
        ////[Route("[controller]/{year}/{month}")]
        //public ActionResult ByReleasedate(int year, int month)
        //{
        //    return Content("year - " + year + "month - " + month);
        //}
    }
}
