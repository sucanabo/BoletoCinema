using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Models
{
    public class Session
    {
        
        public int movie_id { get; set; }
        [ForeignKey("movie_id")]
        public virtual Movie movie { get; set; }

        public int schedule_id {get;set;}
        [ForeignKey("schedule_id")]
        public virtual Schedule schedule { get; set; }

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public DateTime show_date { get; set; }

       

    }
}
