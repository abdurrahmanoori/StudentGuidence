using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentGuidence.Areas.Identity.Controllers
{
    [AllowAnonymous]
    public class AdministrationController : Controller
    {
        public IActionResult CreateRole()
        {
            return View();
        }
    }
}