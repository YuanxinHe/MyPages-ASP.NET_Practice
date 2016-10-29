using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPages.Models;

namespace MyPages.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        // use for MovieFormViewModel to decide 
        // either this movie is a new one or edit pending one
        public bool NewMovie;
    }
}