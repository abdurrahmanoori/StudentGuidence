using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentGuidenc.DataAccess;

namespace StudentGuidence.Areas.Admin.Controllers
{
    public class UniversityController : Controller
    {
        private readonly AppDbContext _db;

        public UniversityController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Universities.ToList());
        }
    }
}