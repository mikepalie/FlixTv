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
    }
}