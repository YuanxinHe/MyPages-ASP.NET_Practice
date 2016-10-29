using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPages.Models;

namespace MyPages.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}