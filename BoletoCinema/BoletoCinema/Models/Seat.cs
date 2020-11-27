using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoCinema.Models
{
    public class Seat
    {
        public int id { get; set; }

        public int room_id { get; set; }

        public string position { get; set; }

        public int status { get; set; }

        [ForeignKey("room_id")]
        public virtual Room room { get; set; }

       // public ICollection<Ticket> ticket { get; set; }
    }
}
