using System;
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
        [ViewData]
        public string Title { get; set; }
        public ViewResult Index()
        {
            Title = "Home By Controller";

            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult Contactus()
        {
            return View();
        }
    }
}