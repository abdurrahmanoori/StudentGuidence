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
//<<<<<<< HEAD
        //[Display(Name ="Establish Date")]
//=======
        [Display(Name ="University Establish Date")]
//>>>>>>> ce2e15ed81cb5d3e2a7e1d2041918361a409b1fb
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString ="")]
        //[Required]
        public DateTime Establishment { get; set; }
    }
}
