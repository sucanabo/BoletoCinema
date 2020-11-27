using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public  string summery { get; set; }

        public  string trailer_path { get; set; }

        public  decimal price { get; set; }

        public int status { get; set; }

        public int duration { get; set; }

        public DateTime published_date { get; set; }

        public ICollection<Session> ListSession { get; set; }
    }
}
