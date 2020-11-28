using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Models
{
    public class MovieDiscount
    {
        public int movie_id { get; set; }
        public int discount_id { get; set; }

        [ForeignKey("movie_id")]
        public virtual Movie movie{ get; set; }

        [ForeignKey("discount_id")]
        public virtual Discount discount{ get; set; }
    }
}
