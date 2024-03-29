﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string GenreName { get; set; }
        
        public virtual ICollection<Movie> Movie { get; set; }
    }
}
