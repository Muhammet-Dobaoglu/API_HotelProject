using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiConsume.Models
{
    public class ApiMovieViewModel
    {
        public Genre[] genres { get; set; }

        public class Genre
        {
            public int id { get; set; }
            public string name { get; set; }
        }

    }
}
