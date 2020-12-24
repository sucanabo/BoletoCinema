using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;
namespace BoletoCinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly BoletoContext _db;

        public HomeController(BoletoContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MovieGrid()
        {
            var movies = _db.movies.ToList();
            ViewData["Title"] = "MovieGrid";
            return View(movies);
        }


        [Route("Home/MovieDetail/{id}")]
        public IActionResult MovieDetail(int ?id)
        {

            
            ViewData["movie_id"] = id;
            return View();
        }

        [Route("Home/MovieTicketPlan/{id}")]
        public IActionResult MovieTicketPlan(int ?id)
        {

           var listBranch = from b in _db.branches
                           from m in _db.movies
                            from s in _db.sessions
                            from sd in _db.schedules
                           where m.id == id && s.movie_id == id && sd.branch_id == b.id && s.schedule_id == sd.id 
                            select new { b.name, b.id, s.movie_id };
       
            var listTime = from s in _db.sessions
                           from m in _db.movies
                           from sd in _db.schedules
                           from b in _db.branches
                           where m.id == id && s.movie_id == m.id && s.schedule_id == sd.id && b.id == sd.branch_id
                           select new { s.start_time, sd.branch_id, s.id };
           

            ViewData["Title"] = "MovieTicketPlan";
            ViewData["_movie_id"] = id;

            ViewBag.Branch = listBranch;
            ViewBag.Time = listTime;
            return View();
        }

        [Route("Home/MovieSeatPlan/{id}")]
        public IActionResult MovieSeatPlan(int ?id)
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
