using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentGuidence.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name Is Required.")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name ="E-Mail")]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Province { get; set; }

        public string District { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Confirm Passwrod")]
        [Compare(otherProperty:"Password",ErrorMessage ="Password Does Not Match!")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public Faculty Faculty { get; set; }

        public Article Article { get; set; }


    }
}
