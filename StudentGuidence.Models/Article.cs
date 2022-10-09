using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentGuidence.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Article Must Have A Title.")]
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Article Must Have A Description.")]
        public string Description { get; set; }
        public DateTime DateOfIssue { get; set; }

    }
}
