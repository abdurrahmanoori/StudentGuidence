using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
    public class TeacherDetailViewModel
    {
        public Teacher Teacher { get; set; }
        
        public List<Article> ArticlesList { get; set; }

        public Article DisplayArticle { get; set; }

    }
}
