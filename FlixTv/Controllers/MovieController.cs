using FlixTv.Models;
using FlixTv.MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlixTv.Controllers
{
    public class MovieController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: Movie
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Category(string Genre, string Year)
        {
            Category cat = new Category() { Genre = Genre, Year = Year };
            return View(cat);
        }

        public ActionResult Details(string Id,string Synopsis)
        {
            Movie movie = new Movie() { MovieId = Id, Synopsis = Synopsis};
            return View(movie);
        }
    }
}