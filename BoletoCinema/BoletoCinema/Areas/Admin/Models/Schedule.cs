using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Schedule
    {
        [Key]
        public int id { get; set; }

        public int room_id { get; set; }

        [ForeignKey("room_id")]
        public virtual Room room { get; set; }

        public ICollection<Ticket> tickets { get; set; }
       
    }
}
