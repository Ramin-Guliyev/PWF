﻿using Microsoft.AspNetCore.Mvc;

namespace PWF.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
