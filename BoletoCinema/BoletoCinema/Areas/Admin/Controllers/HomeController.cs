using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletoCinema.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using BoletoCinema.Areas.Admin.Data;
namespace BoletoCinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User user = Ultils.getCurrentUser(HttpContext);
            if(user.rule != 1)
            {
                var url = Url.RouteUrl("default", new { Controller = "Auth", action = "Login"});
                return Redirect(url);
            }
            return View(user);
        }

        public IActionResult Post()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
