using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentGuidence.Models.ViewModels
{
public    class CreateRoleViewModel
    {
        [Required][Display(Name ="Role Name")]
        public string RoleName { get; set; }
    }
}
