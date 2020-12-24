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

        public int branch_id { get; set; }
        public int room_id { get; set; }

        [ForeignKey("branch_id")]
        public virtual Branch branch { get; set; }
        public virtual Room room { get; set; }

        public ICollection<Ticket> tickets { get; set; }
       
    }
}
