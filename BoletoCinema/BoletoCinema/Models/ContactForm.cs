using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Models
{
    public class ContactForm
    {
        [Key]
        public int id { get; set; }
        public int user_id { get; set; }
        public string content { get; set; }
        public string status { get; set; }
        public string create_date { get; set; }
        [ForeignKey("user_id")]
        public virtual User user { get; set; }
        
    }
}
