﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}