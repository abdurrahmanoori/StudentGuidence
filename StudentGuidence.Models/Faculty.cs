using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentGuidence.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required,Display(Name ="Faculty Name Must Not Be Empty")]
        public string Name { get; set; }
        public string History { get; set; }
        [Required(ErrorMessage ="Please Write Some Pre Reqiremnt Information About Faculty")]
        public string PreRequirment { get; set; }
        public string? ImageUrl { get; set; }
        public int UniversityId { get; set; }
        [ForeignKey("UniversityId")]
        public University University { get; set; }
    }
}
