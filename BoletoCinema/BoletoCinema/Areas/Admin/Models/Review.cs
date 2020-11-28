using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Models
{
    public class Review
    {
        [Key]
        public int id { get; set; }
        public int user_id { get; set; }
        public int movie_id { get; set; }
        public string content { get; set; }
        public int heart_rate { get; set; }
        public DateTime create_date { get; set; }
        [ForeignKey("user_id")]
        public virtual User user { get; set; }
        [ForeignKey("movie_id")]
        public virtual Movie movie { get; set; }
        public ICollection<Report> report { get; set; }
    }
}
