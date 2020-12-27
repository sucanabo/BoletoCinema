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
namespace BoletoCinema.Controllers
{
    public class AuthController : Controller
    {

        private readonly IAuthenticationSchemeProvider authenticationSchemeProvider;
        private readonly BoletoContext _context;
        public AuthController(BoletoContext context, IAuthenticationSchemeProvider authenticationSchemeProvider)
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
            return RedirectToAction("Index", "Home");
        }

        //Trinh
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Log([Bind("username, password")] User user)
        {
            var r = _context.users.Where(m => (m.username == user.username && m.password == StringProcessing.CreateMD5Hash(user.password))).ToList();

            if (r.Count == 0)
            {
                return View("~/Views/Home/SignIn.cshtml");
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