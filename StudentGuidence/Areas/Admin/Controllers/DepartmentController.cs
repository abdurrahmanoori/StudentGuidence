using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentGuidenc.DataAccess;
using StudentGuidence.Models;

namespace StudentGuidence.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _iWebHostEnvironment;

        public DepartmentController(AppDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _iWebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index() => View(_db.Departments.Include(u => u.Faculty).ToList());

        //GET Create
        public IActionResult Create()
        {
            ViewBag.departmentList = _db.Faculties.ToList().Select(u =>
             new SelectListItem
             {
                 Text = u.Name,
                 Value = u.Id.ToString()
             });
            return View();
        }

        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _db.Departments.Add(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }
        //GET Edit
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Department department= _db.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            ViewBag.facultyList = _db.Faculties.Select(u =>
            new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });
            return View(department);
        }
        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {   _db.Departments.Update(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        //GET Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Department department= _db.Departments.Find(id);
            if (department != null)
            {
                ViewBag.facultyList = _db.Faculties.Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(department);
            }
            return NotFound();
        }

        //POST Delete
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            Department department= _db.Departments.Find(id);

            _db.Departments.Remove(department);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}