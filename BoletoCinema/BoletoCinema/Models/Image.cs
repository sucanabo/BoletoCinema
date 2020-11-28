using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Models
{
    public class Image
    {
        [Key]
        public int id { get; set; }
        public int movie_id { get; set; }
        public string path { get; set; }
        public string status { get; set; }
        [ForeignKey("movie_id")]
        public virtual Movie movie { get; set; }

    }
}
