using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.ViewComponents.Dashboard
{
    public class MiddleStatistics : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.projectCount = context.Portfolios.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.referenceCount = context.References.Count();
            return View();
        }
    }
}
