using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletoCinema.Areas.Admin.Models;
using BoletoCinema.Areas.Admin.Data;
namespace BoletoCinema.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User user=Ultils.getCurrentUser(HttpContext);
            return View(user);
        }


        public IActionResult MovieGrid(int? page)
        {

            ViewData["Title"] = "MovieGrid";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }

      

        public IActionResult MovieDetail()
        {
            ViewData["Title"] = "MovieDetail";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }


        public IActionResult MovieTicketPlan()
        {
            ViewData["Title"] = "MovieTicketPlan";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }

        public IActionResult MovieSeatPlan()
        {
            ViewData["Title"] = "MovieSeatPlan";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }
        public IActionResult MovieCheckout()
        {

            ViewData["Title"] = "MovieCheckout";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }

        

        public IActionResult About()
        {
            ViewData["Title"] = "About";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }

        public IActionResult AppDownload()
        {
            ViewData["Title"] = "AppDownload";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }

        public IActionResult SignIn()
        {
            ViewData["Title"] = "SignIn";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }

        public IActionResult SignUp()
        {
            ViewData["Title"] = "SignUp";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }

        public IActionResult Error404()
        {
            ViewData["Title"] = "Error404";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }
    }
}
