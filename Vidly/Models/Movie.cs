using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {

        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }


        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int InStock { get; set; }

    }
}