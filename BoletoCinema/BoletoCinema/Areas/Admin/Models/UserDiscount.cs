using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class UserDiscount
    {
        [Key]
        public int id { get; set; }
        public int user_id { get; set; }
        public int discount_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User user { get; set; }

        [ForeignKey("discount_id")]
        public virtual Discount discount { get; set; }
    }
}
