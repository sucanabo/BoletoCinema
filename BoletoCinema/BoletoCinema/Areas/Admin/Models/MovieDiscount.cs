using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Movie_Discount{
        [Key]
        public int id { get; set; }
        public int movie_id {get;set;}
        public int discount_id { get; set; }
        [ForeignKey("movie_id")]
        public virtual Movie movie { get; set; }
        [ForeignKey("discount_id")]
        public virtual Discount discount { get; set; }
    }
}
