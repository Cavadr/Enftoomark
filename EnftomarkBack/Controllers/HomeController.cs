using EnftomarkBack.DAL;
using EnftomarkBack.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Controllers
{
    //[UserFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
