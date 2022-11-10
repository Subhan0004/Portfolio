using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.ViewComponents.Dashboard
{
    public class LastFiveProjects : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    
    }
}
