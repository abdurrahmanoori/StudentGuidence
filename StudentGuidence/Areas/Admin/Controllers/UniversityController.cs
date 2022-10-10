using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentGuidenc.DataAccess;
using StudentGuidence.Models;

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
        //GET Create
        public IActionResult Create()
        {
            return View();
        }
        //POST Create
        [HttpPost]
        public IActionResult Create(University university)
        {
            if (ModelState.IsValid)
            {
                _db.Universities.Add(university);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}