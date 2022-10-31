using System;
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

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            string userId = claim.Value;
            ViewBag.Poster = null;

            Article article = new Article();
            var user = await userManager.FindByIdAsync(userId);

            if (User.IsInRole(SD.Teacher))
            {
                article.Author = SD.Teacher;
                article.AuthorId = user.Id;
                ViewBag.Poster = _db.Teachers.FirstOrDefault(u => u.Email == user.Email).FirstName;
                return View(article);
            }
            else if (User.IsInRole(SD.Student))
            {
                article.Author = SD.Student;
                article.AuthorId = user.Id;
                ViewBag.Poster = _db.Students.FirstOrDefault(u => u.Email == user.Email).FristName;
                return View(article);
            }
            else
            {
                article.Author = SD.Admin;
                return View(article);
            }

            //var user = userManager.GetUserAsync(HttpContext.User);

            //ViewBag.Id = user.Id;

            //Article article = new Article();
            //article.Author = "Admin";
            //PostCreateViewModel model = new PostCreateViewModel();
            //if (signInManager.IsSignedIn(User) && User.IsInRole("Student"))
            //{
            //    article.Author = "Student";
            //}
            //else if (signInManager.IsSignedIn(User) && User.IsInRole("Teacher"))
            //{
            //    article.Author = "Teacher";
            //}
            //return View(article);

        }

        [HttpPost]
        public IActionResult Create(Article obj, IFormFile? file)
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
                    obj.ImageUrl = @"\images\article\" + fileName + extension;
                }

                _db.Articles.Add(obj);
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
                model.ArticlesList = _db.Articles.Where(u => u.AuthorId == article.AuthorId).Select(u => u.Title);
            }

            else if (article.Author == SD.Student)
            {
                Student student = _db.Students.FirstOrDefault(u => u.Email == user.Email);
                model.Student = student;
                model.ArticlesList = _db.Articles.Where(u => u.AuthorId == article.AuthorId).Select(u => u.Title);
            }
            return View(model);
        }

    }
}