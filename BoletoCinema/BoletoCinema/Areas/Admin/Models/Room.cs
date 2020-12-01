using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Room
    {
        [Key]
        public int id { get; set; }
        public int branch_id { get; set; }

        public string name { get; set; }

        public int status { get; set; }

        [ForeignKey("branch_id")]
        public virtual Branch branch { get; set; }

        public ICollection<Seat> seats { get; set; }
        public ICollection<Ticket> tickets { get; set; }
    }
}
