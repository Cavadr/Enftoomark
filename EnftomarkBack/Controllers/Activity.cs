using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Controllers
{
    public class Activity : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
