using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Models
{
    public class Report
    {
        [Key]
        public int id { get; set; }
        public string reason { get; set; }
        public string content { get; set; }
        public string create_date { get; set; }
        public string status { get; set; }
        public virtual Review review { get; set; }
    }
}
