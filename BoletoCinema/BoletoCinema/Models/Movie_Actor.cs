using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoCinema.Models
{
    public class Movie_Actor
    {
        public int movie_id { get; set; }
        public int actor_id { get; set; }
        [ForeignKey("actor_id")]
        public virtual Actor actor { get; set; }
        //[ForeignKey("movie_id")]
        //public virtual Movie movie { get; set; }
    }
}
