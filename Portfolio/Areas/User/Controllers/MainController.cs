using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Areas.User.Controllers
{
    [Area("User")]
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
