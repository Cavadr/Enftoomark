using Microsoft.AspNetCore.Mvc;
using EnftomarkBack.DAL;
using EnftomarkBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc_BackendProject.Models;

namespace EnftomarkBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class AdditionsController : Controller
    {
        private readonly Context _context;
        public AdditionsController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Additions> additions = _context.Additionss.ToList();
            return View(additions);
        }
        public IActionResult CreateAditions()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateAditions(Additions additions)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Additionss.Any(c => c.Title.ToLower() == additions.Title.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Title", "There is a title with this name");
                return View();
            }
            _context.Additionss.Add(additions);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Additions dbAdditions = _context.Additionss.Find(id);
            if (dbAdditions == null) return NotFound();

            var findId = _context.Additionss.Find(id);
            _context.Additionss.Remove(findId);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int Id)
        {
            var FindId = _context.Additionss.Find(Id);
            return View(FindId);
        }
        [HttpPost]
        public IActionResult Update(int id, Additions a)
        {
            var findId = _context.Additionss.Find(id);
            findId.Title = a.Title;
            findId.Description = a.Description;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
//Footer
//© 2022 GitHub, Inc.
//Footer navigation
//Terms
