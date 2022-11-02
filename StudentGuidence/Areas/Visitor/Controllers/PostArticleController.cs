﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentGuidenc.DataAccess;
using StudentGuidence.Models;
using StudentGuidence.Models.ViewModels;
using StudentGuidence.Utility;

namespace StudentGuidence.Areas.Visitor.Controllers
{
    [AllowAnonymous]
    public class PostArticleController : Controller
    {
        private readonly AppDbContext _db;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment _iWebHostEnvironment;

        public PostArticleController(AppDbContext db, SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            this.signInManager = signInManager;
            this.userManager = userManager;
            _iWebHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> StudentDetail(int id)
        {
            Student student = _db.Students.Find(id); // Find teacher Id in Teacher table.

            var user = await userManager.FindByEmailAsync(student.Email);// as Email attribut is common is aspNetUser and Student
            // tables we found aspNetUser using email property of Teacher table.

            var ArtList = _db.Articles.Where(u => u.AuthorId == user.Id); // We can find articles of a specefic user using 
            // AuthorId property in Article. which is again common in aspNetUser table.

            StudentDetailViewModel model = new StudentDetailViewModel
            {
                Student = student,
                ArticlesList = ArtList
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Teacher1()// Temp method
        {
            return View(_db.Teachers.Include(u => u.Article).ToList());
        }

        public async Task<IActionResult> TeacherDetail(int id)
        {
            Teacher teacher = _db.Teachers.Find(id); // Find teacher Id in Teacher table.

            var user = await userManager.FindByEmailAsync(teacher.Email);// as Email attribut is common is aspNetUser and Teacher
            // tables we found aspNetUser using email property of Teacher table.

            List<Article> ArtList = _db.Articles.Where(u => u.AuthorId == user.Id).ToList(); // We can find articles of a specefic user using 
            // AuthorId property in Article. which is again common in aspNetUser table.

            TeacherDetailViewModel model = new TeacherDetailViewModel
            {
                Teacher = teacher,
                ArticlesList = ArtList
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string userId = claim.Value;

            ViewBag.Poster = null;

            //          Article article = new Article();
            var user = await userManager.FindByIdAsync(userId);

            PostCreateViewModel model = new PostCreateViewModel()
            {
                Teacher = new Teacher(),
                Student = new Student(),
                Article = new Article()
            };
            
            //        model.Article = article;
            if (User.IsInRole(SD.Teacher))
            {
                model.Article.Author = SD.Teacher;
                model.Article.AuthorId = user.Id;
                model.Teacher = _db.Teachers.FirstOrDefault(u => u.Email == user.Email);
                model.Author = _db.Teachers.FirstOrDefault(u => u.Email == user.Email).FirstName;
                model.Article.Id = _db.Articles.FirstOrDefault(u => u.AuthorId == user.Id).Id;
                model.AuthorType = SD.Teacher;
                return View(model);
            }
            else if (User.IsInRole(SD.Student))
            {
                model.Article.Author = SD.Student;
                model.Article.AuthorId = user.Id;
                model.Student = _db.Students.FirstOrDefault(u => u.Email == user.Email);
                model.Author = _db.Students.FirstOrDefault(u => u.Email == user.Email).FristName;
                model.Article.Id = _db.Articles.FirstOrDefault(u => u.AuthorId == user.Id).Id;
                model.AuthorType = SD.Student;
                return View(model);
            }
            else
            {
                model.Author = SD.Admin;
                return View(model);
            }

        }

        [HttpPost]
        public IActionResult Create(PostCreateViewModel obj, IFormFile? file)
        {
            //obj.ImageUrl = file.FileName;

            if (ModelState.IsValid)
            {
                string wwwRootPath = _iWebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\article");
                    var extension = Path.GetExtension(file.FileName);

                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    obj.Article.ImageUrl = @"\images\article\" + fileName + extension;
                }

                if (obj.AuthorType == SD.Teacher)
                {

                    Teacher teacher = new Teacher();
                    teacher = obj.Teacher;
                    teacher.ArticleId = obj.Article.Id;
                    _db.Teachers.Update(teacher);
                    _db.SaveChanges();

                }

                else if (obj.AuthorType == SD.Student)
                {
                    Student student = new Student();
                    student = obj.Student;
                    student.ArticleId = obj.Article.Id;
                    _db.Students.Update(student);
                    _db.SaveChanges();
                }
                obj.Article.Id = 0;
                _db.Articles.Add(obj.Article);
                _db.SaveChanges();

                return RedirectToAction("Post1", obj);
            }
            return View(obj);
        }

        [HttpGet]
        public async Task<IActionResult> Post1(Article article)
        {

            PostDisplayViewModel model = new PostDisplayViewModel
            {
                Article = article
            };
            // Get the user from AspNetUser table
            var user = await userManager.FindByIdAsync(article.AuthorId);

            if (article.Author == SD.Teacher)//If the user is Teacher, then find the correspoding user from teacher table.
            {
                Teacher teacher = _db.Teachers.FirstOrDefault(u => u.Email == user.Email);
                model.Teacher = teacher;
                model.ArticlesList = _db.Articles.Where(u => u.AuthorId == user.Id);
            }

            else if (article.Author == SD.Student)
            {
                Student student = _db.Students.FirstOrDefault(u => u.Email == user.Email);
                model.Student = student;
                model.ArticlesList = _db.Articles.Where(u => u.AuthorId == user.Id);
            }
            return View(model);
        }

    }
}