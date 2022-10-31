using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage ="Email field is requierd")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password field is requierd")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remeber Me")]
        public bool RememberMe { get; set; }
    }
}
