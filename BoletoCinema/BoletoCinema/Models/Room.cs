﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoCinema.Models
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

        public ICollection<Seat> seat { get; set; }
        public ICollection<Ticket> ticket { get; set; }
    }
}
