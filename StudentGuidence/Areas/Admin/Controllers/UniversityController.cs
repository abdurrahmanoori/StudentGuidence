using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentGuidenc.DataAccess;
using StudentGuidence.Models;

namespace StudentGuidence.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UniversityController : Controller
    {
        private readonly AppDbContext _db;

        public UniversityController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Test()
        {
            return View();
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
        [ValidateAntiForgeryToken]
        public IActionResult Create(University university)
        {
            if (university != null)
            {
                if (university.Name == university.Province)
                {
                    ModelState.AddModelError("EqualCheck", "University Name And Province Name Cannot Be Same.");
                }
                if (ModelState.IsValid)
                {
                    _db.Universities.Add(university);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(university);
        }

        //GET Edit
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            University university = _db.Universities.Find(id);
            if (university == null)
            {
                return NotFound();
            }
            return View(university);
        }

        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(University university)
        {
            {
                if (university.Name == university.Province)
                {
                    ModelState.AddModelError("EqualCheck", "University Name And Province Name Cannot Be Same.");
                }

                if (ModelState.IsValid)
                {
                    _db.Universities.Update(university);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(university);

            }
        }

        //GET Delete
        //[HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            University university = _db.Universities.Find(id);
            if (university != null)
            {
                return View(university);
            }
            return NotFound();
        }

        //POST Delete
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            University universityDelete = _db.Universities.Find(id);
            if (universityDelete != null)
            {
                _db.Universities.Remove(universityDelete);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}