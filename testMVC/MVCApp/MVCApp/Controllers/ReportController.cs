﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View("Reports");
        }
    }
}