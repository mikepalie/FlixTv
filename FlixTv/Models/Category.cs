using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixTv.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Genre { get; set; }

        public string Year { get; set; }
    }
}