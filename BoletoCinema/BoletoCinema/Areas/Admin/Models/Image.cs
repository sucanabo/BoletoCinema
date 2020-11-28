using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Image
    {
        [Key]
        public int id { get; set; }
        public int movie_id { get; set; }
        public string path { get; set; }
        public int status { get; set; }
        [ForeignKey("movie_id")]
        public virtual Movie movie { get; set; }

    }
}
