using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentGuidence.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessageResourceName ="Deparmtent Name Must Not Be Empty!")]
        public string Name { get; set; }
        public string History { get; set; }
        [Required(ErrorMessage ="Please Add Some Pre Requiremnt For Department")]
        public string PreRequirment { get; set; }
        public int FacultyId { get; set; }
        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }
    }
}
