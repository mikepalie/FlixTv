using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FlixTv.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Genre { get; set; }

        public string Year { get; set; }

        public string MinRating { get; set; }
        public string MaxRating { get; set; }
        public string SortingBy { get; set; }
        
    }
}