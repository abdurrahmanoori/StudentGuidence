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
    public class StudentController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _iWebHostEnvironment;

        public StudentController(AppDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _iWebHostEnvironment = webHostEnvironment;
        }

        //public IActionResult Post()
        //{
        //    return RedirectToAction("Create")
        //}

        public IActionResult Detail(int id) => View(_db.Students.Find(id));
        //{
        //    return View(_db.Students.Find(id));
        //}

        public IActionResult Index()
        {
            var stu = _db.Students.Include(u => u.Article).ToList();

            return View(stu);
        }

        //GET Create
        public IActionResult Create()
        {
            ViewBag.departmentList = _db.Departments.ToList().Select(u =>
                  new SelectListItem
                  {
                      Text = u.Name,
                      Value = u.Id.ToString()
                  }
                );
            //ViewBag.aritcleList = _db.Articles.ToList().Select(u =>
            // new SelectListItem
            // {
            //     Text = u.Title,
            //     Value = u.Id.ToString()
            // });

            //ViewBag.universityList = _db.Universities.ToList().Select(u =>
            //new SelectListItem
            //{
            //    Text = u.Name,
            //    Value = u.Id.ToString()
            //});
            return View();
        }

        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student, IFormFile file)
        {

            student.ImageUrl = file.FileName;

            if (ModelState.IsValid)
            {
                string wwwRootPath = _iWebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\student");
                    var extension = Path.GetExtension(file.FileName);

                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    student.ImageUrl = @"\images\student\" + fileName + extension;
                }
                _db.Students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        //GET Edit
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Student student = _db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewBag.departmentList = _db.Departments.ToList().Select(u =>
                  new SelectListItem
                  {
                      Text = u.Name,
                      Value = u.Id.ToString()
                  }
                );
            ViewBag.aritcleList = _db.Articles.ToList().Select(u =>
             new SelectListItem
             {
                 Text = u.Title,
                 Value = u.Id.ToString()
             });
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student, IFormFile? file)
        {
            Student student1 = new Student
            {
                Id = student.Id,
                FristName = student.FristName,
                LastName = student.LastName,
                Email=student.Email,
                Province = student.Province,
                District = student.District,
                ImageUrl = student.ImageUrl,
                UniversityStartDate = student.UniversityStartDate,
                DepartmentId = student.DepartmentId,
                ArticleId = student.ArticleId
            };

            if (ModelState.IsValid)
            {
                string wwwRootPath = _iWebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\student");
                    var extension = Path.GetExtension(file.FileName);
                    if (student1.ImageUrl != null)
                    {
                        //LOGIC ABOUT DELETING OLD IMAGE
                        var oldImagePath = Path.Combine(wwwRootPath, student1.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    student1.ImageUrl = @"\images\student\" + fileName + extension;
                }

                _db.Students.Update(student1);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student1);
        }

        //GET Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Student student= _db.Students.Find(id);
            if (student != null)
            {
                ViewBag.departmentList = _db.Departments.Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                ViewBag.articleList = _db.Articles.Select(u =>
                  new SelectListItem
                  {
                      Text = u.Title,
                      Value=u.Id.ToString()
                  });
                return View(student);
            }
            return NotFound();
        }

        //POST Delete
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            Student student= _db.Students.Find(id);
            string wwwRootPath = _iWebHostEnvironment.WebRootPath;

            if (student.ImageUrl != null)
            {
                //LOGIC ABOUT DELETING OLD IMAGE
                var oldImagePath = Path.Combine(wwwRootPath, student.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _db.Students.Remove(student);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public string GetImageUrl(Student student)
        {
            using (AppDbContext2 context = new AppDbContext2())
            {
                int id = student.Id;
                return context.Students.Find(id).ImageUrl;
            }

        }
    }
}
