using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Controllers
{
    public class Explore : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
