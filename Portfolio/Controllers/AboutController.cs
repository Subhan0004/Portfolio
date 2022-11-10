using BusineesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new AboutRepository());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.value1 = "Update About";
            ViewBag.value2 = "About";
            var value = aboutManager.GetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.Update(about);
            return RedirectToAction("Index", "Main");
        }
    }
}
