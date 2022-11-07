using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentGuidenc.DataAccess;
//using StudentGuidence.Models;
using StudentGuidence.Models;

namespace StudentGuidence.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult TestShow()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Universities()
        {
            return View(_db.Universities.ToList());
        }

        public IActionResult Faculty(int universityId)
        {
            //var faculties= _db.Faculties.ToList().Where(u => u.UniversityId == universityId);
            var faculties = _db.Faculties.Where(u => u.UniversityId == universityId).Include(u=>u.University).ToList();
            return View(faculties);
        }

        //================= Team Page ==================//
        public IActionResult Team()
        {
            return View();
        }

        //================= Contact Page ==================//
        public IActionResult Contact()
        {
            return View();
        }

        //================= About Page ==================//
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
