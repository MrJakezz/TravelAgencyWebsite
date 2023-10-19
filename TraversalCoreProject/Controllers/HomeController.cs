﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index sayfası çağrıldı.");
            _logger.LogError("Error log çağrıldı.");

            return View();
        }

        public IActionResult Privacy()
        {
            DateTime dt = Convert.ToDateTime(DateTime.Now.ToLongDateString());

            _logger.LogInformation(dt + " Privacy sayfası çağrıldı.");

            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation("Test sayfası çağrıldı.");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}