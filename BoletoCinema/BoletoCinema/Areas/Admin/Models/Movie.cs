using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        [Required]

        public string summery { get; set; }
        [Required]
        public string poster { get; set; }

        public string trailer_path { get; set; }
        [Required]

        public int status { get; set; }
        [Required]

        public int duration { get; set; }

        public DateTime published_date { get; set; }
        public ICollection<Movie_Discount> movieDiscounts { get; set; }
        public ICollection<Movie_Category> movie_Categories { get; set; }
        public ICollection<Movie_Actor> movie_Actors { get; set; }
        public ICollection<Review> reviews { get; set; }
        public ICollection<Schedule> schedules { get; set; }
    }
}
