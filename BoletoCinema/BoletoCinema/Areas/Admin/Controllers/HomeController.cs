using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletoCinema.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BoletoCinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
            User user = new User();
            user.username = us.SelectToken("username").ToString();
            user.password = us.SelectToken("password").ToString();
            user.rule = Int32.Parse(us.SelectToken("rule").ToString());
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
