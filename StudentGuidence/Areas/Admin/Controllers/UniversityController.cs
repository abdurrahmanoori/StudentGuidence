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
            if (ModelState.IsValid)
            {
                _db.Universities.Add(university);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(university);
        }
        //GET Edit
        public IActionResult Edit(int id)
        {
            University university = _db.Universities.Find(id);
            if(university != null && university.Id >=0)
            {
                return View(university);
            }
            return NotFound();
        }
        //POST Edit
        [HttpPost] 
        [ValidateAntiForgeryToken]
        public IActionResult Edit(University university)
        {
            if (ModelState.IsValid)
            {

                if (university != null)
                {
                    _db.Universities.Update(university);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(university);

        }
        //GET Delete
        //[HttpGet]
        public IActionResult Delete(int id)
        {
            University university = _db.Universities.Find(id);
            if(university != null)
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
            if(universityDelete != null)
            {
                _db.Universities.Remove(universityDelete);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}