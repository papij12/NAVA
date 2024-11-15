﻿using Microsoft.AspNetCore.Mvc;


namespace NAVA_MVP1.Controllers
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

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Documentation ()
        {
            return View();
        }
        public IActionResult Contact() 
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}