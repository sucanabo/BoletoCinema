using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoCinema.Models
{
    public class Branch
    {
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string status { get; set; }

        public ICollection<Schedule> schedule { get; set; }

        public ICollection<Room> room { get; set; }
    }
}
