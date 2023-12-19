using FlixTv.Models;
using FlixTv.MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using FlixTv.Repositories;
using System.Threading.Tasks;
using Filter = FlixTv.Models.Filter;

namespace FlixTv.Controllers
{
    public class MovieController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        
        public MovieService _testService = new MovieService();

        

        // GET: Movie
        public ActionResult Index()
        {
            
            return View();
        }
        
        public async Task<ActionResult> Category(string Genre, string Year, string MinRating, string MaxRating, string SortingBy, string special, int? page, int? pSize )
        {
            ViewBag.Genre = Genre;
            ViewBag.Year = Year;
            ViewBag.MinRating = MinRating;
            ViewBag.MaxRating = MaxRating;
            ViewBag.SortingBy = SortingBy;
            ViewBag.Special = special;

            Filter filter = new Filter() { Genre = Genre, Year = Year, MinRating = MinRating, MaxRating = MaxRating, SortingBy = SortingBy };
            var result = await _testService.GetMoviesWithFilters(filter);
            var data = result.results;
            

            int pageSize = pSize ?? 18;
            int pageNumber = page ?? 1;

            return View(data.ToPagedList(pageNumber, pageSize)  );
        }

        public ActionResult Details(string Id)
        {
            Movie movie = new Movie() { ImdbId = Id};
            return View(movie);
        }

        public async Task<ActionResult> Search(string Title, int? page, int? pSize)
        {
            ViewBag.Search = Title;
            var result = await _testService.GetMoviesWithSearchingTitle(Title);
            var data = result.results;


            int pageSize = pSize ?? 18;
            int pageNumber = page ?? 1;

            return View(data.ToPagedList(pageNumber, pageSize));
        }
        
    }
}