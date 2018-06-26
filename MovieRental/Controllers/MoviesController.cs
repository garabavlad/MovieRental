using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name" });
            //return Content("Hello world");
            return View(viewModel);
        }

        // When clicked in NavBar on "Movies", user will be sent here.
        // An action to show all available movies:
        public ActionResult ShowAll()
        {
            return View();
        }

        // When clicked in NavBar on "Top", user will be sent here.
        // An action to show top 5 movies:
        public ActionResult Top()
        {
            return View();
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (sortBy.IsNullOrWhiteSpace())
            {
                sortBy = "Name";
            }

            return View();
        }


        /*
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }*/

    }
}