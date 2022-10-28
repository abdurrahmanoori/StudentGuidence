using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        public PostArticleController(AppDbContext db, SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _db = db;
            this.signInManager = signInManager;
            this.userManager = userManager;
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
        public IActionResult Create(Article obj)
        {
            if (ModelState.IsValid)
            {
                obj.ImageUrl = "pathAbc";

                _db.Articles.Add(obj);
                _db.SaveChanges();

                return View("Post1", obj);
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult Post1(Article article)
        {
            return View(article);
        }

    }
}