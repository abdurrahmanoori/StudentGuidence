using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using StudentGuidence.Models;
using StudentGuidence.Models;

namespace StudentGuidence.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //================= Home Page (Index) ==================//
        public IActionResult Index()
        {
            return View();
        }

        //================= Login Page ==================//
        public IActionResult Login()
        {
            return View();
        }

        //================= Registration Page ==================//
        public IActionResult Registration()
        {
            return View();
        }

        //================= Universities Page ==================//
        public IActionResult Universities()
        {
            return View();
        }

        //================= Faculty Page ==================//
        public IActionResult Faculty()
        {
            return View();
        }

        //================= Teacher Page ==================//
        public IActionResult Teacher()
        {
            return View();
        }

        //================= Student Page ==================//
        public IActionResult Student()
        {
            return View();
        }


        //================= Services Page ==================//
        public IActionResult Services()
        {
            return View();
        }

        //================= Team Page ==================//
        public IActionResult Team()
        {
            return View();
        }

        //================= Contact Page ==================//
        public IActionResult Contact()
        {
            return View();
        }

        //================= About Page ==================//
        public IActionResult About()
        {
            return View();
        }



        //================= Waiting Page ==================//
        public IActionResult Waitingpage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
