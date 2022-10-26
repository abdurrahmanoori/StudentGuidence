using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentGuidence.Models
{
    public class University
    {
        [Key]
        public int Id { get; set; }

        [Required,Display(Name ="University Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="University name must not be empty")]
        public string Province { get; set; }

        public string ImageUrl { get; set; }

        [Display(Name ="University Establish Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString ="")]
        //[Required]
        public DateTime Establishment { get; set; }
    }
}
