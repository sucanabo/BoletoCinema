using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Report
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string reason { get; set; }
        [Required]
        public string content { get; set; }
        public int review_id { get; set; }
        public string create_date { get; set; }
        public int status { get; set; }
        [ForeignKey("review_id")]
        public virtual Review review { get; set; }
    }
}
