using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
   public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UserType { get; set; }

        [Compare(otherProperty: "ConfirmPassword"),Required,DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
