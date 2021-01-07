using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletoCinema.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please Enter Username.."), StringLength(32,MinimumLength = 8)]
        public string username { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Please Enter Email..."), StringLength(50,MinimumLength = 15)]
        public string email { get; set; }
        [Required(ErrorMessage = "Please Enter Password..."), DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "Please Enter the Confirm Password...")]
        [DataType(DataType.Password), Compare(nameof(password))]
        public string confirmPassword { get; set; }
    }
}
