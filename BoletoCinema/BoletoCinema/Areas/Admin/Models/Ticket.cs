using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Ticket
    {
        [Key]
        public int id { get; set; }

        public int? order_id { get; set; }
        [ForeignKey("order_id")]
        public virtual Order order { get; set; }

        public int? schedule_id { get; set; }
        [ForeignKey("schedule_id")]
        public virtual Schedule schedule { get; set; }

        public double price { get; set; }
        public ICollection<Seat_Status> seat_Statuses { get; set; }
    }
}
