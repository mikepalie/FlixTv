using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixTv.Models
{
    public class Data
    {
        public int page { get; set; }
        public List<Movie> results { get; set; }
    }
}