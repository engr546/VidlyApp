using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }
            
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        // Foreign Key
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreTypeId { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 1000)]
        public short? Stocks { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
            ReleaseDate = DateTime.Now;
            Stocks = 1;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            GenreTypeId = movie.GenreTypeId;
            Stocks = movie.Stocks;
        }

    }
}