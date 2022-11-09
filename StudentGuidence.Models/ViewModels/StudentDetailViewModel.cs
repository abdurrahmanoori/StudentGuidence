using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
    public class StudentDetailViewModel
    {
        public Student Student { get; set; }
        
      //  public ApplicationUser ApplicationUserTeacher { get; set; }

        public List<Article> ArticlesList { get; set; }

    }
}
