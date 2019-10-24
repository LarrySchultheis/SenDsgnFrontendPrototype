using System;
using MVCApp.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        [HttpGet]
        public IActionResult Login()
        {
            int a = 0;
            return View();
        }

        public IActionResult Privacy()
        {
            int a = 0;
            return View("Index");
        }

        public IActionResult DataEntry()
        {
            return View("DataEntry");
        }

        public IActionResult HomePage()
        {
            return View("HomePage");
        }

        [HttpPost]
        public IActionResult VerifyLogin(User user)
        {

            return View("HomePage", user);
        }

        [HttpPost]
        public IActionResult PostEntry(DummyData d)
        {
            int x=0;
            DataEntry de = new DataEntry();
            de.PostEntry(d);
            return View("HomePage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
