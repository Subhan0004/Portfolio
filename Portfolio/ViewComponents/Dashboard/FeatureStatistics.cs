using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.unreadmessageCount = context.Messages.Where(x=>x.Status==false).Count();
            ViewBag.allmessageCount = context.Messages.Count();
            ViewBag.experienceCount = context.Experiences.Count();
            return View();
        }
    }
}
