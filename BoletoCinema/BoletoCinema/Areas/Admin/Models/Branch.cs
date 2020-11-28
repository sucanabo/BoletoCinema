using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoCinema.Areas.Admin.Models
{
    public class Branch
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public int status { get; set; }

        public ICollection<Schedule> schedules { get; set; }

        public ICollection<Room> rooms { get; set; }
    }
}
