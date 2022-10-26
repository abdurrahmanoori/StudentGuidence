using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace StudentGuidence.Models.ViewModels
{

    public class RegisterViewModel
    {
        [EmailAddress][Required]
        //[Remote(action:"IsEmailInUse",controller:"Account")]
        public string Email { get; set; }

        [Required, Display(Name = "I Am")]
        public string UserType { get; set; }

        [Compare(otherProperty: "ConfirmPassword"), Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
