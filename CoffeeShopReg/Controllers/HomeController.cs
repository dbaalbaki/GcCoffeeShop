using CoffeeShopReg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopReg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(string weight, string height, string firstname, string lastname, string password, string email, string phonenumber, string gender, string username)
        {
            ViewData["FirstName"] = firstname;
            ViewData["LastName"] = lastname;
            ViewData["PhoneNumber"] = phonenumber;
            ViewData["UserName"] = username;
            ViewData["Gender"] = gender;
            ViewData["Weight"] = weight;
            ViewData["Height"] = height;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
