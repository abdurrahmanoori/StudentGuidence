using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
    public class PostCreateViewModel
    {
        //public int Id { get; set; }

        //public string Title { get; set; }

        //public string ImageUrl { get; set; }

        //public string Description { get; set; }

         public string Author { get; set; }

        public string AuthorType { get; set; }

        public Article Article { get; set; }

        public Teacher Teacher { get; set; }

        public Student Student { get; set; }

        public Admin Admin { get; set; }


    }
}
