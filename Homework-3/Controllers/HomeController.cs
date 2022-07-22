using Microsoft.AspNetCore.Mvc;
using Le_Crystal_HW3.DAL;
using Le_Crystal_HW3.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

//Crystal Le- CL44964

namespace Le_Crystal_HW3.Controllers
{
    public class HomeController : Controller
    {
        //instance
        private AppDbContext _context;

        //constructor
        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        // GET: Home 
        public ActionResult Index(string SearchString) //Simple Search
        {
            //LINQ Query
            var query = from b in _context.Movies
                        select b;


            if (SearchString == null)
            {
                //Populate the view bag with a count of all movies 
                ViewBag.AllMovies = _context.Movies.Count();

                //Populate the view bag with a count of selected movies 
                ViewBag.SelectedMovies = ViewBag.AllMovies;
                return View(_context.Movies.OrderBy(s => s.Title).ToList());
            }

            else
            {
                query = query.Where(b => b.Title.Contains(SearchString) ||
                                      b.Description.Contains(SearchString));
                List<Movie> SelectedMovies = query.Include(b => b.Genre).ToList();
                //Populate the view bag with a count of all movies 
                ViewBag.AllMovies = _context.Movies.Count();

                //Populate the view bag with a count of selected movies 
                ViewBag.SelectedMovies = SelectedMovies.Count;
                return View(SelectedMovies.OrderBy(s => s.Title));
            }
        }

        public IActionResult DetailedSearch()
        {
            //Navigational Property
            ViewBag.AllGenres = GetAllGenres();
            

            return View();
        }

        private SelectList GetAllGenres()
        {
            //Get the list of months from the database
            List<Genre> genreList = _context.Genres.ToList();

            //add a dummy entry so the user can select all months
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };
            genreList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList genreSelectList = new SelectList(genreList.OrderBy(g => g.GenreID), "GenreID", "GenreName");

            //return the electList
            return genreSelectList;
        }

        

        public IActionResult DisplaySearchResults(SearchViewModel svm) //uses View Model
        {
            var query = from m in _context.Movies select m;
            ViewBag.AllMovies = GetAllGenres();

            //TitleSearch query
            if (svm.TitleSearch != null && svm.TitleSearch != "")
            {
                query = query.Where(m => m.Title.Contains(svm.TitleSearch));
            }
            //Description Search query
            if (svm.DescriptionSearch != null)
            {
                query = query.Where(m => m.Description.Contains(svm.DescriptionSearch));
            }
            //Genre Search Query
            if (svm.SelectedGenreID != 0)
            {
                query = query.Where(m => m.Genre.GenreID == svm.SelectedGenreID);
            }
            //Rating Serach Query
            if (svm.RatingSearch != null) ///Rating not working
            {
                query = query.Where(m => m.Rating == svm.RatingSearch);
            }
            //User Rating
            if (svm.UserNumRating != 0)
            {

                switch (svm.UserRatingSearch)
                {
                    case UserRating.GreaterThan:
                        query = query.Where(m => m.VoteAverage >= svm.UserNumRating);
                        break;
                    case UserRating.LessThan:
                        query = query.Where(m => m.VoteAverage <= svm.UserNumRating);
                        break;
                    default:
                        break;
                }
            }

            //Release Date query
            if (svm.ReleaseDateSearch != null)
            {
                query = query.Where(m => m.ReleaseDate >= svm.ReleaseDateSearch);
            }

            //return only selected movies and how many out of 300 movies were found
            List<Movie> SelectedMovies = query.Include(m => m.Genre).ToList();
            ViewBag.AllMovies = _context.Movies.Count();
            ViewBag.SelectedMovies = SelectedMovies.Count;
            return View("Index", SelectedMovies.OrderBy(m => m.Title));
        }

        //details page view
        public IActionResult Details (int? id) //id is the id of the movie you want to see
        {

            if (id == null) //MovieID not specified
            {
                return View("Error", new string[] { "MovieID not specified - which movie do you want to view?"});
            }

            //look up the movie in the database based on the id' be sure to include the genre

            Movie movie = _context.Movies.Include(b => b.Genre).FirstOrDefault(b => b.MovieID == id);

            if (movie == null) //No movie with this id exists in the database
            {
                //there is not a movie with this id in the database - show an error view
                return View("Error", new string[] {"Movie not found in database"});
            }

            //if code gets this far, all is well - display the details
            return View(movie);
        }
    }
}
