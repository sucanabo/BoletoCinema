using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using BoletoCinema.ViewModel;
namespace BoletoCinema.Controllers
{
    public class AuthController : Controller
    {

        private readonly IAuthenticationSchemeProvider authenticationSchemeProvider;
        private readonly BoletoContext _context;

        public AuthController(BoletoContext context, 
            IAuthenticationSchemeProvider authenticationSchemeProvider)
        {
            _context = context;
            this.authenticationSchemeProvider = authenticationSchemeProvider;
        }
        public async Task<IActionResult> Login()
        {
            var allSchemeProvider = (await authenticationSchemeProvider.GetAllSchemesAsync())
                .Select(n => n.DisplayName).Where(n => !String.IsNullOrEmpty(n));
            return View(allSchemeProvider);
        }

        public IActionResult SignIn(String provider)
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/" }, provider);
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        //Sign up
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var allUser = _context.users.ToList();
                foreach(var item in allUser)
                {
                    if (item.username == model.username)
                        return RedirectToAction("SignUp", "Auth");
                }
                var user = new User
                {
                    username = model.username,
                    displayname = model.username,
                    email = model.email,
                    password = StringProcessing.CreateMD5Hash(model.password),
                    rule = 0
                };
                _context.Add<User>(user);
                await _context.SaveChangesAsync();
                var str = JsonConvert.SerializeObject(user);
                HttpContext.Session.SetString("user", str);
                if (user.rule == 1)
                {
                    var url = Url.RouteUrl("Admin", new { Controller = "Home", action = "Index", area = "Admin" });
                    return Redirect(url);
                }

                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("SignUp", "Auth");
        }
        //Sign in
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Log([Bind("username, password")] User user)
        {
            var r = _context.users.Where(m => (m.username == user.username && m.password == StringProcessing.CreateMD5Hash(user.password))).ToList();

            if (r.Count == 0)
            {
                return RedirectToAction("Login", "Auth");
            }
            var str = JsonConvert.SerializeObject(r[0]);
            HttpContext.Session.SetString("user", str);
            if (r[0].rule == 1)
            {
                var url = Url.RouteUrl("Admin", new { Controller = "Home", action = "Index", area = "Admin" });
                return Redirect(url);
            }

            return RedirectToAction("Index", "Home");

        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}