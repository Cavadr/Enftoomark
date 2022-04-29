using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnftomarkBack.DAL;
using EnftomarkBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnftomarkBack.Controllers
{
    public class Image : Controller
    {
        private readonly Context _context;
        public Image(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Images> images = _context.Images.ToList();
            return View(images);
        }
    }
}
