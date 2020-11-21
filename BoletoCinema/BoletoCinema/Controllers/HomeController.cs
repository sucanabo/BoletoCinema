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

        public IActionResult Index2()
        {
            ViewData["Title"] = "Index2";
            return View();
        }

        public IActionResult MovieGrid()
        {
            ViewData["Title"] = "MovieGrid";
            return View();
        }

        public IActionResult MovieList()
        {
            ViewData["Title"] = "MovieList";
            return View();
        }

        public IActionResult MovieDetail()
        {
            ViewData["Title"] = "MovieDetail";
            return View();
        }

        public IActionResult MovieDetail2()
        {
            ViewData["Title"] = "MovieDetail2";
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

        public IActionResult MovieFood()
        {
            ViewData["Title"] = "MovieFood";
            return View();
        }

        public IActionResult Event()
        {
            ViewData["Title"] = "Event";
            return View();
        }

        public IActionResult EventDetail()
        {
            ViewData["Title"] = "EventDetail";
            return View();
        }

        public IActionResult EventSpeaker()
        {
            ViewData["Title"] = "EventSpeaker";
            return View();
        }

        public IActionResult EventTicket()
        {
            ViewData["Title"] = "EventTicket";
            return View();
        }

        public IActionResult EventCheckout()
        {
            ViewData["Title"] = "EventCheckout";
            return View();
        }

        public IActionResult Sport()
        {
            ViewData["Title"] = "Sport";
            return View();
        }

        public IActionResult SportDetail()
        {
            ViewData["Title"] = "SportDetail";
            return View();
        }

        public IActionResult SportTicket()
        {
            ViewData["Title"] = "SportTicket";
            return View();
        }

        public IActionResult SportCheckout()
        {
            ViewData["Title"] = "SportCheckout";
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

        public IActionResult Blog()
        {
            ViewData["Title"] = "Blog";
            return View();
        }

        public IActionResult BlogSingle()
        {
            ViewData["Title"] = "BlogSingle";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            return View();
        }
    }
}
