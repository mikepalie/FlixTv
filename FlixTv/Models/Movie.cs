using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixTv.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }

        public int ProductionYear { get; set; }
        public int Duration { get; set; }
        public string Casting { get; set; }
        public double Rating { get; set; }

        public string Genre { get; set; }
        public string Description { get; set; }
    }
}