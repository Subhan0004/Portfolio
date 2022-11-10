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
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new FeatureRepository());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.value1 = "Updating";
            ViewBag.value2 = "Update Page";
            var value = featureManager.GetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.Update(feature);
            return RedirectToAction("Index", "Main");
        }
    }
}
