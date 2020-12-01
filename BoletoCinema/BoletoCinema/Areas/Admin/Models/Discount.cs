using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Discount
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public double discount_percent { get; set; }
        public int status { get; set; }

        public ICollection<Movie_Discount> movieDiscounts { get; set; }
        public ICollection<UserDiscount> user_discount { get; set; }
    }
}
