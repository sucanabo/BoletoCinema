using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BoletoCinema.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public int status { get; set; }
        public ICollection<Movie_Category> movie_category { get; set; }
    }
}
