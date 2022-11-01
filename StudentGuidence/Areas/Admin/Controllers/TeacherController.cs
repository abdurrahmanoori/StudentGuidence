using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentGuidenc.DataAccess;
using StudentGuidence.DataAccess.Data;
using StudentGuidence.Models;

namespace StudentGuidence.Areas.Admin.Controllers
{
    [AllowAnonymous]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _iWebHostEnvironment;

        public TeacherController(AppDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _iWebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Detail(int id) => View(_db.Teachers.Find(id));

        public IActionResult Index() => View((_db.Teachers.Include(u => u.Faculty).ToList()));

        //GET Create
        public IActionResult Create()
        {
            ViewBag.facultyList = _db.Faculties.ToList().Select(u =>
                  new SelectListItem
                  {
                      Text = u.Name,
                      Value = u.Id.ToString()
                  });
            ViewBag.aritcleList = _db.Articles.ToList().Select(u =>
             new SelectListItem
             {
                 Text = u.Title,
                 Value = u.Id.ToString()
             });
            return View();
        }

        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher, IFormFile file)
        {

            teacher.ImageUrl = file.FileName;

            if (ModelState.IsValid)
            {
                string wwwRootPath = _iWebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\teacher");
                    var extension = Path.GetExtension(file.FileName);

                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    teacher.ImageUrl = @"\images\teacher\" + fileName + extension;
                }
                _db.Teachers.Add(teacher);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teacher);
        }

        //GET Edit
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Teacher teacher = _db.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            ViewBag.facultyList = _db.Faculties.ToList().Select(u =>
                  new SelectListItem
                  {
                      Text = u.Name,
                      Value = u.Id.ToString()
                  });
            ViewBag.aritcleList = _db.Articles.ToList().Select(u =>
             new SelectListItem
             {
                 Text = u.Title,
                 Value = u.Id.ToString()
             });
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Teacher teacher, IFormFile? file)
        {
            Teacher teacher1 = new Teacher
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Degree = teacher.Degree,
                Province = teacher.Province,
                District = teacher.District,
                ImageUrl = teacher.ImageUrl,
                Phone = teacher.Phone,
                Email = teacher.Email,
                FacultyId = teacher.FacultyId,
                ArticleId = teacher.ArticleId
            };

            if (ModelState.IsValid)
            {
                string wwwRootPath = _iWebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\teacher");
                    var extension = Path.GetExtension(file.FileName);
                    if (teacher1.ImageUrl != null)
                    {
                        //LOGIC ABOUT DELETING OLD IMAGE
                        var oldImagePath = Path.Combine(wwwRootPath, teacher1.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    teacher1.ImageUrl = @"\images\teacher\" + fileName + extension;
                }

                _db.Teachers.Update(teacher1);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teacher1);
        }

        //GET Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Teacher teacher = _db.Teachers.Find(id);
            if (teacher != null)
            {
                ViewBag.facultyList = _db.Faculties.Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                ViewBag.articleList = _db.Articles.Select(u =>
                  new SelectListItem
                  {
                      Text = u.Title,
                      Value = u.Id.ToString()
                  });
                return View(teacher);
            }
            return NotFound();
        }

        //POST Delete
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            Teacher teacher = _db.Teachers.Find(id);
            string wwwRootPath = _iWebHostEnvironment.WebRootPath;

            if (teacher.ImageUrl != null)
            {
                //LOGIC ABOUT DELETING OLD IMAGE
                var oldImagePath = Path.Combine(wwwRootPath, teacher.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _db.Teachers.Remove(teacher);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public string GetImageUrl(Teacher teacher)
        {
            using (AppDbContext2 context = new AppDbContext2())
            {
                int id = teacher.Id;
                return context.Teachers.Find(id).ImageUrl;
            }
        }
    }
}