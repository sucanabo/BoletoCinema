using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoCinema.Areas.Admin.Models
{
    public class Seat_Status
        
    {
        [Key]
        public int id { get; set; }
        public int seat_id { get; set; }
        public int ticket_id { get; set; }
        public int status { get; set; }
        [ForeignKey("seat_id")]
        public virtual Seat Seat { get; set; }
        [ForeignKey("ticket_id")]
        public virtual Ticket Ticket { get; set; }
    }
}
