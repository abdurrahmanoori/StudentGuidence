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

        public string Author { get; set; }// Where 1 is Admin, 2 is Teacher and 3 is Student

        public DateTime DateOfIssue { get; set; }
    }
}
