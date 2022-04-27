using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Controllers
{
    public class UploadController : Controller
    {
        private readonly string wwwrootDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads");
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile mylife)
        {
            if (mylife!=null)
            {
                var path = Path.Combine(wwwrootDir, DateTime.Now.Ticks.ToString() + Path.GetExtension(mylife.FileName));
                using (var stream= new FileStream(path,FileMode.Create))
                {
                    await mylife.CopyToAsync(stream);
                }
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
