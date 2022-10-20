using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGuidence.Models
{
   public class ApplicationUser:IdentityUser
    {
        public string UserType { get; set; }
    }
}
