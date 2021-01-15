﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly BoletoContext _db;

        public HomeController(BoletoContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            User user=Ultils.getCurrentUser(HttpContext);
            var nowDate = DateTime.Now;
            var newsestMovie = (from m in _db.movies
                                orderby m.published_date descending
                                select m).Take(3);
            //var hotMovie = from m in _db.movies
            //               from sch in _db.schedules
            //               from tk in _db.tickets
            //               where m.id == sch.movie_id && sch.id == tk.schedule_id
            //               group m by m.id into g
            //               orderby g.Count()
            //               select new { Movie = g};
            ViewBag.Newsest = newsestMovie.ToArray();
            //ViewBag.Hot = hotMovie.ToArray();
            return View(user);
        }


        public IActionResult MovieGrid(int? page)
        {

            ViewData["Title"] = "MovieGrid";
            User user = Ultils.getCurrentUser(HttpContext);
            ViewBag.Cate = _db.categories.ToArray();
            ViewBag.Movies = _db.movies.ToArray();
            ViewBag.Branches = _db.branches.ToArray();
            ViewBag.Schedules = _db.schedules.ToArray();
            return View(user);

        }

        public IActionResult Search(string nameFilm, DateTime schedulesTime, string branchesName)
        {   
                
            if(nameFilm == null)
            {
                var listSearch = from br in _db.branches
                                 from sc in _db.schedules
                                 from mv in _db.movies
                                 where br.name == branchesName && sc.start_time == schedulesTime
                                 select new { mv.id, mv.name, mv.poster };
                ViewBag.resultSearch = listSearch;
                ViewBag.Branches = _db.branches.ToArray();
                ViewBag.Schedules = _db.schedules.ToArray();
                ViewBag.Cate = _db.categories.ToArray();
                ViewBag.Movies = _db.movies.ToArray();

               
            }
            else if (schedulesTime == null)
            {
                var listSearch = from br in _db.branches
                                 from sc in _db.schedules
                                 from mv in _db.movies
                                 where br.name == branchesName && mv.name == nameFilm
                                 select new { mv.id, mv.name, mv.poster };
                ViewBag.resultSearch = listSearch;
                ViewBag.Branches = _db.branches.ToArray();
                ViewBag.Schedules = _db.schedules.ToArray();
                ViewBag.Cate = _db.categories.ToArray();
                ViewBag.Movies = _db.movies.ToArray();

            }
            else if (branchesName == null)
            {
                var listSearch = from br in _db.branches
                                 from sc in _db.schedules
                                 from mv in _db.movies
                                 where mv.name == nameFilm && sc.start_time == schedulesTime
                                 select new { mv.id, mv.name, mv.poster };
                ViewBag.resultSearch = listSearch;
                ViewBag.Branches = _db.branches.ToArray();
                ViewBag.Schedules = _db.schedules.ToArray();
                ViewBag.Cate = _db.categories.ToArray();
                ViewBag.Movies = _db.movies.ToArray();

            }
            else
            {
                var listSearch = from br in _db.branches
                                 from sc in _db.schedules
                                 from mv in _db.movies
                                 where mv.name == nameFilm && sc.start_time == schedulesTime&& br.name == branchesName
                                 select new { mv.id, mv.name, mv.poster };
                ViewBag.resultSearch = listSearch;
                ViewBag.Branches = _db.branches.ToArray();
                ViewBag.Schedules = _db.schedules.ToArray();
                ViewBag.Cate = _db.categories.ToArray();
                ViewBag.Movies = _db.movies.ToArray();
            }    
            return View();
        }
         
        [Route("Home/MovieDetail/{id}")]




        public IActionResult MovieDetail(int? id)
        {


            ViewBag.Movie = _db.movies.Where(m => m.id == id).ToArray();
            var listTag = from ct in _db.categories
                          from mct in _db.movie_Categories
                          where ct.id == mct.category_id && mct.movie_id == id
                          select ct.name;
            var listCast = from ac in _db.actors
                           from mac in _db.movie_Actors
                           where ac.id == mac.actor_id && mac.movie_id == id
                           select ac;
            var test = from rv in _db.reviews
                       from us in _db.users
                       where us.id == rv.user_id && rv.movie_id == id
                       select new { rv.content, us.username, rv.heart_rate,us.avatar };
            ViewBag.Test = test;
            ViewBag.Review = _db.reviews.Where(m => m.movie_id == id).ToArray();
            ViewBag.listCast = listCast.ToArray();
            ViewBag.listTag = listTag.ToArray();
            ViewData["movie_id"] = id;
            return View();
        }

        [Route("Home/MovieTicketPlan/{id}")]
        public IActionResult MovieTicketPlan(int? id)
        {

            var listBranch = from b in _db.branches
                             from m in _db.movies
                             from sd in _db.schedules
                             from r in _db.rooms
                             where m.id == id && sd.movie_id == id && sd.movie_id == m.id && sd.room_id == r.id && r.branch_id == b.id
                             select new { b.name, b.id, sd.movie_id };

            var listTime = from m in _db.movies
                           from sd in _db.schedules
                           from b in _db.branches
                           from r in _db.rooms
                           where m.id == id && m.id == sd.movie_id && sd.room_id == r.id && r.branch_id == b.id
                           select new { sd.id, sd.start_time, r.branch_id, sd.room_id};



            ViewData["Title"] = "MovieTicketPlan";
            ViewData["_movie_id"] = id;

            ViewBag.Branch = listBranch;
            ViewBag.Time = listTime;



            return View();
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
