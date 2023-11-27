using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixTv.Models
{
    public class Series
    {
        public int SeriesId { get; set; }
        public string Title { get; set; }
        public int ProductionYear { get; set; }
        public int NumberOfEpisode { get; set; }
        public int Season { get; set; }
        public string Casting { get; set; }
        public double Rating { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }

    }
}