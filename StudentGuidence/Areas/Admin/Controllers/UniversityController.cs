using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentGuidenc.DataAccess;
using StudentGuidence.DataAccess.Data;
using StudentGuidence.Models;

namespace StudentGuidence.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UniversityController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _iWebHostEnvironment;

        public UniversityController(AppDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _iWebHostEnvironment = webHostEnvironment;
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
        public IActionResult Create(University university, IFormFile file)
        {

            if (university != null)
            {
                if (university.Name == university.Province)
                {
                    ModelState.AddModelError("EqualCheck", "University Name And Province Name Cannot Be Same.");
                }

                university.ImageUrl = file.FileName;

                if (ModelState.IsValid)
                {
                    string wwwRootPath = _iWebHostEnvironment.WebRootPath;
                    if (file != null)
                    {
                        string fileName = Guid.NewGuid().ToString();
                        var uploads = Path.Combine(wwwRootPath, @"images\university");
                        var extension = Path.GetExtension(file.FileName);

                        using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                        {
                            file.CopyTo(fileStreams);
                        }
                        university.ImageUrl = @"\images\university\" + fileName + extension;
                    }

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
        public IActionResult Edit(University university, IFormFile? file)
        {
            University university1 = new University
            {
                Id = university.Id,
                Name = university.Name,
                Province = university.Province,
                ImageUrl = GetImageUrl(university),
                Establishment = university.Establishment
            };

            {
                if (university.Name == university.Province)
                {
                    ModelState.AddModelError("EqualCheck", "University Name And Province Name Cannot Be Same.");
                }

                if (ModelState.IsValid)
                {
                    string wwwRootPath = _iWebHostEnvironment.WebRootPath;
                    if (file != null)
                    {
                        string fileName = Guid.NewGuid().ToString();
                        var uploads = Path.Combine(wwwRootPath, @"images\university");
                        var extension = Path.GetExtension(file.FileName);
                        if (university1.ImageUrl != null)
                        {
                            //LOGIC ABOUT DELETING OLD IMAGE
                            var oldImagePath = Path.Combine(wwwRootPath, university1.ImageUrl.TrimStart('\\'));
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }
                        using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                        {
                            file.CopyTo(fileStreams);
                        }
                        university1.ImageUrl = @"\images\university\" + fileName + extension;
                    }

                    _db.Universities.Update(university1);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(university1);

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

            string wwwRootPath = _iWebHostEnvironment.WebRootPath;
            if (universityDelete.ImageUrl != null)
            {
                //LOGIC ABOUT DELETING OLD IMAGE
                var oldImagePath = Path.Combine(wwwRootPath, universityDelete.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            if (universityDelete != null)
            {
                _db.Universities.Remove(universityDelete);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public string GetImageUrl(University university)
        {
            using (AppDbContext2 context = new AppDbContext2())
            {
                int id = university.Id;
                return context.Universities.Find(id).ImageUrl;
            }

        }
    }




}