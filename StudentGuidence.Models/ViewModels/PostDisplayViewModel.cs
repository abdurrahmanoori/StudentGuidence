using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
    public class PostDisplayViewModel
    {
        public Article Article { get; set; }
        
        public Teacher Teacher { get; set; }

        public Student Student { get; set; }

        public IQueryable <string> ArticlesList { get; set; }
    }
}
