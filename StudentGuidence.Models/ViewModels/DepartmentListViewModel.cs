using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
    public class DepartmentListViewModel
    {
        public IEnumerable<Department> Departments { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}
