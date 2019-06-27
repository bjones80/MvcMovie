using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class SingleMovieGenreViewModel
    {
        public Movie Movie { get; set; }
        public SelectList Genres { get; set; }
    }
}
