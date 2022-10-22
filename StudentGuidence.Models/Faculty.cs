﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentGuidence.Models
{
    //[Authorize(Roles ="Admin")]
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Faculty Name Must Not Be Empty"), Display(Name ="Faculty Name" )]
        public string Name { get; set; }
        public string History { get; set; }
        [Required(ErrorMessage = "Please Write Some Pre Reqiremnt Information About Faculty")]
        public string PreRequirment { get; set; }
        public string? ImageUrl { get; set; }
        public int? UniversityId { get; set; }
        [ForeignKey("UniversityId")]
        public University University { get; set; }
    }
}
