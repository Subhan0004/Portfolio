using BusineesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.ViewComponents.Reference
{
    public class ReferenceList : ViewComponent
    {
        ReferenceManager referenceManager = new ReferenceManager(new ReferenceRepository());

        public IViewComponentResult Invoke()
        {
            var values = referenceManager.GetList();
            return View(values);
        }


    }
}
