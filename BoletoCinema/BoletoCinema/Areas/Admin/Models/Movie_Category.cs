using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Movie_Category
    {
        [Key]
        public int id { get; set; }
        public int category_id { get; set; }
        public int movie_id { get; set; }
        [ForeignKey("category_id")]
        public virtual Category category { get; set; }
        [ForeignKey("movie_id")]
        public virtual Movie movie { get; set; }
    }
}
