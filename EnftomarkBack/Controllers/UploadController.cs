using EnftomarkBack.DAL;
using EnftomarkBack.Extensions;
using EnftomarkBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Controllers
{
    public class UploadController : Controller
    {

        private readonly ILogger<UploadController> _logger;
        private readonly Context _db;
        private readonly IWebHostEnvironment _env;

        public UploadController(ILogger<UploadController> logger, Context db,IWebHostEnvironment env)
        {
            _env = env;
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            var images = _db.Images.ToList();
            return View(images);
        }

        public IActionResult AddProfile()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProfile(Images img)
        {
            if (!img.Picture.IsImage())
            {
                ModelState.AddModelError("Photo", "only image");
                return RedirectToAction("Index");
            }
            if (img.Picture.IsCorrectSize(3000))
            {
                ModelState.AddModelError("Photo", "please enter photo under 3000kb");
                return RedirectToAction("Index");
            }
            Images images = new Images();

            images.Name = img.Name;
            images.Price = img.Price;
            images.Desc = img.Desc;
            images.PictureUrl = await img.Picture.SaveImageAsync(_env.WebRootPath, "assets/images/");

            await _db.Images.AddAsync(images);
            await _db.SaveChangesAsync();

            
            return RedirectToAction("Profile", "Account");
        }
        
    }
}
