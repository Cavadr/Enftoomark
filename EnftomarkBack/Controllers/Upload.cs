using EnftomarkBack.DAL;
using EnftomarkBack.Models;
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
    public class Upload : Controller
    {

        private readonly ILogger<Upload> _logger;
        private readonly Context _db;

        public Upload(ILogger<Upload> logger, Context db)
        {
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
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0)
                {
                    byte[] pic = null;
                    using(var filestream = files[0].OpenReadStream())
                    {
                        using(var memorystream=new MemoryStream())
                        {
                            filestream.CopyTo(memorystream);
                            pic = memorystream.ToArray();
                        }
                    }
                    img.Picture = pic;
                }
                _db.Images.Add(img);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(img);
        }
        
    }
}
