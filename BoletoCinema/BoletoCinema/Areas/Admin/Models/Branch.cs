using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class Branch
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(255)]

        public string name { get; set; }
        [Required]
        [StringLength(255)]
        public string address { get; set; }
        [Required]
        [Range(0,1)]

        public int status { get; set; }

        public ICollection<Room> rooms { get; set; }
    }
}
