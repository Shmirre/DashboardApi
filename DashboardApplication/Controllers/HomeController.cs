﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DashboardApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: View
        public IActionResult Index()
        {
            return View();
        }
    }
}