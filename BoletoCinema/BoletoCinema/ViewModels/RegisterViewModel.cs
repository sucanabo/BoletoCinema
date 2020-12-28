using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BoletoCinema.ViewModel
{
    public class RegisterViewModel
    {
        [Required, MaxLength(255)]
        public string username { get; set; }
        [EmailAddress]
        [Required, MaxLength(50)]
        public string email { get; set; }
        [Required, DataType(DataType.Password)]
        public string password { get; set; }
        [DataType(DataType.Password), Compare(nameof(password))]
        public string confirmPassword { get; set; }
    }
}
