using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixTv.Models
{
    public class Result
    {
        public int page { get; set; }
        public List<MovieTest> results { get; set; }
    }
}