using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentGuidenc.DataAccess;
using StudentGuidence.Models;

namespace StudentGuidence.Areas.Admin.Controllers
{
    public class FacultyController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _iWebHostEnvironment;

        public FacultyController(AppDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _iWebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_db.Faculties.ToList());
        }
        //GET Create

        public IActionResult Create()
        {
            ViewBag.universityList = _db.Universities.ToList().Select(u =>
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
        public IActionResult Create(Faculty faculty, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _iWebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\faculty");
                    var extension = Path.GetExtension(file.FileName);

                    if (faculty.ImageUrl != null)
                    {
                        //LOGIC ABOUT DELETING OLD IMAGE
                        var oldImagePath = Path.Combine(wwwRootPath, faculty.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    faculty.ImageUrl = @"\images\faculty\" + fileName + extension;
                }

                _db.Faculties.Add(faculty);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(faculty);

            //GET Edit
            //public IActionResult Edit(int id)
            //{
            //    if (id == 0)
            //    {
            //        return NotFound();
            //    }
            //    University university = _db.Universities.Find(id);
            //    if (university == null)
            //    {
            //        return NotFound();
            //    }
            //    return View(university);
            //}
            ////POST Edit
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public IActionResult Edit(University university)
            //{
            //    {
            //        if (university.Name == university.Province)
            //        {
            //            ModelState.AddModelError("EqualCheck", "University Name And Province Name Cannot Be Same.");
            //        }

            //        if (ModelState.IsValid)
            //        {
            //            _db.Universities.Update(university);
            //            _db.SaveChanges();
            //            return RedirectToAction("Index");
            //        }

            //        return View(university);

            //    }
            //}
            ////GET Delete
            ////[HttpGet]
            //public IActionResult Delete(int id)
            //{
            //    if (id == 0)
            //    {
            //        return NotFound();
            //    }
            //    University university = _db.Universities.Find(id);
            //    if (university != null)
            //    {
            //        return View(university);
            //    }
            //    return NotFound();
            //}
            ////POST Delete
            //[HttpPost]
            //[ActionName("Delete")]
            //public IActionResult DeletePost(int id)
            //{
            //    University universityDelete = _db.Universities.Find(id);
            //    if (universityDelete != null)
            //    {
            //        _db.Universities.Remove(universityDelete);
            //        _db.SaveChanges();
            //        return RedirectToAction("Index");
            //    }
            //    return NotFound();
            //}
        }
    }
}