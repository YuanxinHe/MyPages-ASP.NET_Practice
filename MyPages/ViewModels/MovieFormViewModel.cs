using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;
using MyPages.Models;

namespace MyPages.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseTime { get; set; }
        
        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }
        
        // use for MovieFormViewModel to decide 
        // either this movie is a new one or edit pending one
        public string Title
        {
            get { return Id != 0 ? "Edit Movie" : "New Movie"; }
        }
        // use for new movie page initialization
        public MovieFormViewModel()
        {
            Id = 0;
        }
        // use for creating/editing a movie
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseTime = movie.ReleaseTime;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}