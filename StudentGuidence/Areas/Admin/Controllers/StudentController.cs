using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentGuidenc.DataAccess;

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
        public IActionResult Detail(int id)
        {
            return View(_db.Students.Find(id));
        }

        public IActionResult Index()
        {
            return View(_db.Students.Include(u => u.Article));
        }

        //GET Create
        public IActionResult Create()
        {
            //ViewBag.universityList = _db.Universities.ToList().Select(u =>
             //new SelectListItem
             //{
             //    Text = u.Name,
             //    Value = u.Id.ToString()
             //});
            return View();
        }

        ////POST Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Faculty faculty, IFormFile file)
        //{

        //    faculty.ImageUrl = file.FileName;

        //    if (ModelState.IsValid)
        //    {
        //        string wwwRootPath = _iWebHostEnvironment.WebRootPath;
        //        if (file != null)
        //        {
        //            string fileName = Guid.NewGuid().ToString();
        //            var uploads = Path.Combine(wwwRootPath, @"images\faculty");
        //            var extension = Path.GetExtension(file.FileName);

        //            using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
        //            {
        //                file.CopyTo(fileStreams);
        //            }
        //            faculty.ImageUrl = @"\images\faculty\" + fileName + extension;
        //        }
        //        _db.Faculties.Add(faculty);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(faculty);
        //}
        ////GET Edit
        //public IActionResult Edit(int id)
        //{
        //    if (id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Faculty faculty = _db.Faculties.Find(id);
        //    if (faculty == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewBag.universityList = _db.Universities.Select(u =>
        //    new SelectListItem
        //    {
        //        Text = u.Name,
        //        Value = u.Id.ToString()
        //    });
        //    return View(faculty);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(Faculty faculty, IFormFile? file)
        //{
        //    Faculty faculty1 = new Faculty
        //    {
        //        Name = faculty.Name,
        //        PreRequirment = faculty.PreRequirment,
        //        UniversityId = faculty.UniversityId,
        //        History = faculty.History,
        //        ImageUrl = GetImageUrl(faculty),
        //        Id = faculty.Id,
        //        University = faculty.University
        //    };

        //    if (ModelState.IsValid)
        //    {
        //        string wwwRootPath = _iWebHostEnvironment.WebRootPath;
        //        if (file != null)
        //        {
        //            string fileName = Guid.NewGuid().ToString();
        //            var uploads = Path.Combine(wwwRootPath, @"images\faculty");
        //            var extension = Path.GetExtension(file.FileName);
        //            if (faculty1.ImageUrl != null)
        //            {
        //                //LOGIC ABOUT DELETING OLD IMAGE
        //                var oldImagePath = Path.Combine(wwwRootPath, faculty1.ImageUrl.TrimStart('\\'));
        //                if (System.IO.File.Exists(oldImagePath))
        //                {
        //                    System.IO.File.Delete(oldImagePath);
        //                }
        //            }

        //            using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
        //            {
        //                file.CopyTo(fileStreams);
        //            }
        //            faculty1.ImageUrl = @"\images\faculty\" + fileName + extension;
        //        }

        //        _db.Faculties.Update(faculty1);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(faculty1);
        //}

        ////GET Delete
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    if (id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Faculty faculty = _db.Faculties.Find(id);
        //    if (faculty != null)
        //    {
        //        ViewBag.UniversityList = _db.Universities.Select(u => new SelectListItem
        //        {
        //            Text = u.Name,
        //            Value = u.Id.ToString()
        //        });
        //        return View(faculty);
        //    }
        //    return NotFound();
        //}

        ////POST Delete
        //[HttpPost]
        //[ActionName("Delete")]
        //public IActionResult DeletePost(int id)
        //{
        //    Faculty faculty = _db.Faculties.Find(id);
        //    string wwwRootPath = _iWebHostEnvironment.WebRootPath;

        //    if (faculty.ImageUrl != null)
        //    {
        //        //LOGIC ABOUT DELETING OLD IMAGE
        //        var oldImagePath = Path.Combine(wwwRootPath, faculty.ImageUrl.TrimStart('\\'));
        //        if (System.IO.File.Exists(oldImagePath))
        //        {
        //            System.IO.File.Delete(oldImagePath);
        //        }
        //    }
        //    _db.Faculties.Remove(faculty);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");

        //}

        //public string GetImageUrl(Faculty faculty)
        //{
        //    using (AppDbContext2 context = new AppDbContext2())
        //    {
        //        int id = faculty.Id;
        //        return context.Faculties.Find(id).ImageUrl;
        //    }

        //}
    }
}