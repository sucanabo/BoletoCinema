using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Movie_Actor
    {
        [Key]
        public int id { get; set; }
        public int movie_id { get; set; }
        public int actor_id { get; set; }
        [ForeignKey("actor_id")]
        public virtual Actor actor { get; set; }
        [ForeignKey("movie_id")]
        public virtual Movie movie { get; set; }
    }
}
