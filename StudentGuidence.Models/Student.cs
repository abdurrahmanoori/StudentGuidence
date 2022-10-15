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
        //public DateTime UniversityStartDate { get; set; } = DateTime.Now;
        public DateTime UniversityStartDate { get; set; } 
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public int ArticleId { get; set; }
        [ForeignKey("ArticleId")]
        public Article Article { get; set; }
    }
}
