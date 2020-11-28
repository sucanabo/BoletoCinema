using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoCinema.Models
{
    public class Movie_Category
    {
        public int category_id { get; set; }
        public int movie_id { get; set; }
        [ForeignKey("category_id")]
        public virtual Category category { get; set; }
        [ForeignKey("movie_id")]
        public virtual Movie movie { get; set; }
    }
}
