using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 1000)]
        public short Stocks { get; set; }

        public short Available { get; set; }

        // Navigation Property
        public GenreType GenreType { get; set; }

        // Foreign Key
        [Display(Name = "Genre")]
        public byte GenreTypeId { get; set; }

    }
}