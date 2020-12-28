using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.Areas.Admin.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string displayname { get; set; }
        public string email { get; set; }
        public DateTime birthday { get; set; }
        public string avatar { get; set; }
        public int rule { get; set; }
        public ICollection<Review> reviews { get; set; }
        public ICollection<ContactForm> contactForms { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<UserDiscount> userDiscounts { get; set; }
    }
}
