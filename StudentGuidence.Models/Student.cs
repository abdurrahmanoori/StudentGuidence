using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentGuidence.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="First Name Is Required."),Display(Name ="First Name")]
        public string FristName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Compare(otherProperty:"ConfrimPassword",ErrorMessage ="Password and confirm passwrod are not same."),Required(ErrorMessage ="Password Field is Required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped,DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }
        public DateTime UniversityStartDate { get; set; } 
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public int ArticleId { get; set; }
        [ForeignKey("ArticleId")]
        public Article Article { get; set; }
    }
}
