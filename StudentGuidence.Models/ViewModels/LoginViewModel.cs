using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string UsernameOrEmail { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remeber Me")]
        public bool RememberMe { get; set; }
    }
}
