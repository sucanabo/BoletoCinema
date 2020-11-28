using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoCinema.Models
{
    public class Schedule
    {
        [Key]
        public int id { get; set; }

        public int branch_id { get;set;}

        [ForeignKey("branch_id")]
        public virtual Branch branch { get; set; }

        public ICollection<Ticket> tickets{get;set;}
    }
}
