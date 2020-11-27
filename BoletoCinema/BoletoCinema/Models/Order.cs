using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        public int user_id { get; set; }
        [ForeignKey("user_id")]
        public virtual User user { get; set; }

        public int ticket_id { get; set; }
        [ForeignKey("ticket_id")]
        public virtual Ticket ticket { get; set; }

        public decimal total_price { get; set; }

        public int status { get; set; }

        public DateTime create_date { get; set; }
    }
}
