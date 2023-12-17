using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixTv.Models
{
    public class Movie
    {
        public string ImdbId { get; set; }
        public List<string> ImageUrl { get; set; }
        public List<string> Genre { get; set; }
        public string Title { get; set; }
        public double? ImdbRating { get; set; }
        public int Released { get; set; }
        public string Type { get; set; }
        public string Synopsis { get; set; }
    }
}