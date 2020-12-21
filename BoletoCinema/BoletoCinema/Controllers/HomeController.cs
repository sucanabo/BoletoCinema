using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BoletoCinema.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MovieGrid()
        {
            ViewData["Title"] = "MovieGrid";
            return View();
        }

      

        public IActionResult MovieDetail()
        {
            ViewData["Title"] = "MovieDetail";
            return View();
        }


        public IActionResult MovieTicketPlan()
        {
            ViewData["Title"] = "MovieTicketPlan";
            return View();
        }

        public IActionResult MovieSeatPlan()
        {
            ViewData["Title"] = "MovieSeatPlan";
            return View();
        }
        public IActionResult MovieCheckout()
        {

            ViewData["Title"] = "MovieCheckout";
            return View();
        }

        

        public IActionResult About()
        {
            ViewData["Title"] = "About";
            return View();
        }

        public IActionResult AppDownload()
        {
            ViewData["Title"] = "AppDownload";
            return View();
        }

        public IActionResult SignIn()
        {
            ViewData["Title"] = "SignIn";
            return View();
        }

        public IActionResult SignUp()
        {
            ViewData["Title"] = "SignUp";
            return View();
        }

        public IActionResult Error404()
        {
            ViewData["Title"] = "Error404";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            return View();
        }
    }
}
