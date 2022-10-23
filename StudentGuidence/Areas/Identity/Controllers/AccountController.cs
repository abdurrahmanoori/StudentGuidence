﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentGuidenc.DataAccess;
using StudentGuidence.Models;
using StudentGuidence.Models.ViewModels;

namespace StudentGuidence.Areas.Identity.Controllers
{

    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(AppDbContext db, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
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
                if (_db.Users.Any(u => u.Email == model.Email && u.UserName == model.UserName))
                {
                    ModelState.AddModelError("", "This email or user name has been already taken.");
                    return View(model);
                }
                ApplicationUser user = new ApplicationUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    UserType = model.UserType
                };
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
                if (model.UsernameOrEmail.Contains("@"))
                {
                    user = await userManager.FindByEmailAsync(model.UsernameOrEmail);
                }
                else
                {
                    user = await userManager.FindByNameAsync(model.UsernameOrEmail);
                }

                var result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                //signInManager.pas
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
        //[Authorize(Roles ="User")]
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

    }
}