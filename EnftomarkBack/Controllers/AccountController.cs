using EnftomarkBack.DAL;
using EnftomarkBack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly Context _context;
        public AccountController(Context context)
        {
            _context = context;
        }
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Login(string username,int pass)
        {
            var user = _context.User.FirstOrDefault(w=>w.UserName.Equals(username) && w.Password.Equals(pass));
            if (user!=null)
            {
                HttpContext.Session.SetInt32("id", user.id);
                HttpContext.Session.SetString("username",user.UserName);
                HttpContext.Session.SetString("name", user.Name);
                HttpContext.Session.SetString("country", user.Country);
                HttpContext.Session.SetString("wallet", user.WalletAdd);
                return Redirect("/Home/Index");
            }
                return Redirect("SignIn");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/Index");
        }
        public async Task<IActionResult> Register(User model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();

            return Redirect("SignIn");
        }
    }
}
