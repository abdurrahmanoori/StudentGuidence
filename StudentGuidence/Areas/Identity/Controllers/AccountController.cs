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
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentGuidenc.DataAccess;
using StudentGuidence.DataAccess.Data;
using StudentGuidence.Models;
using StudentGuidence.Models.ViewModels;
using StudentGuidence.Utility;

namespace StudentGuidence.Areas.Identity.Controllers
{

    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IWebHostEnvironment _iWebHostEnvironment;

        public AccountController(AppDbContext db, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
            _iWebHostEnvironment = webHostEnvironment;
        }

        //[AcceptVerbs("GET","POST")]
        //public async Task<IActionResult> IsEmailInUse(string email)
        //{
        //    ApplicationUser user = await userManager.FindByEmailAsync(email);

        //    if (user == null)
        //    {
        //        return Json(true);
        //    }
        //    else
        //    {
        //        return Json($"The Email: {user.Email} has benn already in use.");
        //    }

        //    return View();
        //}

        public IActionResult Show()
        {

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        //[Authorize(Roles ="Admin")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Check wether this email has been already taken or not.
                if (_db.Users.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("", "This user name has been already taken.");
                    return View(model);
                }
                ApplicationUser user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    UserType = model.UserType
                };

                if (model.UserType == SD.Teacher)
                {
                    Teacher teacher = new Teacher
                    {
                        Email = model.Email
                    };
                    _db.Teachers.Update(teacher);
                    _db.SaveChanges();
                }
                else if (model.UserType == SD.Student)
                {
                    Student student = new Student
                    {
                        Email = model.Email,
                        FacultyId = null,
                        UniversityId = null

                    };
                    //student.FacultyId = 1008;
                    _db.Students.Add(student);
                    _db.SaveChanges();
                }

                IdentityResult result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    ViewBag.Message = $"Successfully user: {user.UserName} Created.";
                    return RedirectToAction("Show", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    
        public async Task<IActionResult> AddRegistrationDetail4Teacher()//For Teacher
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string userId = claim.Value;

            var user = await userManager.FindByIdAsync(userId);
            Teacher teacher = _db.Teachers.FirstOrDefault(u => u.Email == user.Email);

            ViewBag.facultyList = _db.Faculties.ToList().Select(u =>
            new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            return View(teacher);
        }

        [HttpPost]
        public IActionResult AddRegistrationDetail4Teacher(Teacher teacher, IFormFile? file)
        {
            Teacher teacher1= new Teacher
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Degree=teacher.Degree,
                Email = teacher.Email,
                Phone=teacher.Phone,
                Province = teacher.Province,
                District = teacher.District,
                ImageUrl = GetImageUrl(teacher),
                ArticleId = teacher.ArticleId,
                FacultyId = teacher.FacultyId,
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
                return RedirectToAction("Index", "Home", new { Area = "Visitor" });
            }
            return View(teacher1);
        }

        public async Task<IActionResult> AddRegistrationDetail()//For Student
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string userId = claim.Value;

            var user = await userManager.FindByIdAsync(userId);
            Student student = _db.Students.FirstOrDefault(u => u.Email == user.Email);

            ViewBag.departmentList = _db.Departments.ToList().Select(u =>
            new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            ViewBag.universityList = _db.Universities.ToList().Select(u =>
            new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });
            ViewBag.facultyList = _db.Faculties.ToList().Select(u =>
            new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            return View(student);
        }

        [HttpPost]
        public IActionResult AddRegistrationDetail(Student student, IFormFile? file)
        {
            Student student1 = new Student
            {
                Id = student.Id,
                FristName = student.FristName,
                LastName = student.LastName,
                Email = student.Email,
                Province = student.Province,
                District = student.District,
                ImageUrl = GetImageUrl(student),
                UniversityStartDate = student.UniversityStartDate,
                DepartmentId = student.DepartmentId,
                ArticleId = student.ArticleId,
                FacultyId = student.FacultyId,
                UniversityId = student.UniversityId
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
                return RedirectToAction("Index", "Home", new { Area = "Visitor" });
            }
            return View(student1);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user;
                user = await userManager.FindByNameAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", $"The email '{model.Email}' does not registerd yet.");
                    return View(model);
                }

                var result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (ReturnUrl != null)
                        return LocalRedirect(ReturnUrl);

                    return RedirectToAction("Index", "Home", new
                    {
                        area = "Visitor"
                    });
                    //return Redirect("~/Visitor/Home/Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Attemps.");
                }
            }
            return View(model);
        }
        //[HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new
            {
                area = "Visitor"
            });
            //return RedirectToAction("Login");
            //return Redirect("~Visitor/Home/Index");
        }

        public string GetImageUrl(Student student)
        {
            using (AppDbContext2 context = new AppDbContext2())
            {
                int id = student.Id;
                return context.Students.Find(id).ImageUrl;
            }

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