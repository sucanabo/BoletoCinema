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
using BoletoCinema.ViewModels;
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
        public IActionResult SignUp()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
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
                    {
                        SetAlert("User already existed in system", "warning");
                        return View(model);
                    }
                        
                }
                var m_username = model.username.Trim().Length;
                if(m_username <=5 || m_username > 32)
                {
                    ModelState.AddModelError("", "User name must be between 6 - 32 character.");
                    SetAlert("Username invalid", "warning");
                    return View(model);
                }
                var m_pwd = model.password.Trim();
                var valid_pwd = ValidatePassword(m_pwd);
                if(valid_pwd.Count != 0)
                {
                    foreach(var item in valid_pwd)
                    {
                        if (item == -1) ModelState.AddModelError("", "Password must be between 8-32 character.");
                        else if (item == -2) ModelState.AddModelError("", "Password must have least one uppercase letter.");
                        else if (item == -3) ModelState.AddModelError("", "Password must have least one lowercase letter.");
                        else if (item == -4) ModelState.AddModelError("", "Password must have least one number.");
                        else if(item == -5) ModelState.AddModelError("", "Password must have least one special letter.");
                    }
                    SetAlert("Password invalid", "warning");
                    return View(model);
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
                SetAlert("Sign up success", "success");
                return RedirectToAction("Index", "Home");
                }
                
            SetAlert("Register fail", "danger");
            return View(model);
        }
        //Sign in
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Log([Bind("username, password")] User user)
        {
            var r = _context.users.Where(m => (m.username == user.username && m.password == StringProcessing.CreateMD5Hash(user.password))).ToList();

            if (r.Count == 0)
            {
                SetAlert("Login fail - Username or password wrong !", "warning");
                return RedirectToAction("Login", "Auth");
            }
            var str = JsonConvert.SerializeObject(r[0]);
            HttpContext.Session.SetString("user", str);
            if (r[0].rule == 1)
            {
                var url = Url.RouteUrl("Admin", new { Controller = "Home", action = "Index", area = "Admin" });
                SetAlert("Login success - Admin", "success");
                return Redirect(url);
            }
            SetAlert("Login success - User", "success");
            return RedirectToAction("Index", "Home");

        }
        
        public IActionResult Index()
        {
            return View();
        }
        public void SetAlert (String mess, String type)
        {
            TempData["alert-mess"] = mess;
            if(type == "success")
            {
                TempData["alert-type"] = "alert-success";
            }
            else if (type == "danger") TempData["alert-type"] = "alert-danger";
            else TempData["alert-type"] = "alert-warning";
        }
        public List<int> ValidatePassword(String password)
        {
            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 32;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;
            bool hasSpecialLetter = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                    else if (!char.IsLetterOrDigit(c)) hasSpecialLetter = true;
                }
            }
            List<int> err = new List<int>();
            if (!meetsLengthRequirements) err.Add(-1);
            if (!hasUpperCaseLetter) err.Add(-2);
            if (!hasLowerCaseLetter) err.Add(-3);
            if (!hasDecimalDigit) err.Add(-4);
            if (!hasSpecialLetter) err.Add(-5);
            //bool isValid = meetsLengthRequirements
            //            && hasUpperCaseLetter
            //            && hasLowerCaseLetter
            //            && hasDecimalDigit;

            //return isValid;
            return err;
        }
    }
}