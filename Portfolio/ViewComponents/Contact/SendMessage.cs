using BusineesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
