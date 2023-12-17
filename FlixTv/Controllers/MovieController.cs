using FlixTv.Models;
using FlixTv.MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using FlixTv.Repositories;
using System.Threading.Tasks;

namespace FlixTv.Controllers
{
    public class MovieController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        
        public TestService _testService = new TestService();

        

        // GET: Movie
        public ActionResult Index()
        {
            
            return View();
        }
        
        public ActionResult Category(string Genre, string Year, string MinRating, string MaxRating, string SortingBy                                 )
        {
            Category cat = new Category() { Genre = Genre, Year = Year, MinRating = MinRating, MaxRating = MaxRating, SortingBy = SortingBy };
            return View(cat);
        }

        public ActionResult Details(string Id)
        {
            Movie movie = new Movie() { MovieId = Id};
            return View(movie);
        }

        public ActionResult Search(string Title)
        {
            Movie movie = new Movie() { Title = Title };
            return View(movie);
        }
        public async Task<ActionResult> Test(string genre, string minRating)
        {
            Category cat = new Category() { Genre = genre, MinRating = minRating };
            var result = await _testService.GetMoviesWithFilters(cat);
            var data = result.results; 
            return View(data);
        }
    }
}