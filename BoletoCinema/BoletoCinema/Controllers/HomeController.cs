    using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletoCinema.Areas.Admin.Models;
using BoletoCinema.Areas.Admin.Data;
using X.PagedList;

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
            User user = Ultils.getCurrentUser(HttpContext);
            var nowDate = DateTime.Now;

            var newsestMovie = (from m in _db.movies
                                orderby m.published_date descending
                                select m).Take(3);

            var onShowMovie = _db.movies.Where(m => m.status == 1).Take(3);

            var onCommingMovie = _db.movies.Where(m => m.status == 2).Take(3);

            ViewBag.Newsest = newsestMovie.ToArray();
            ViewBag.OnShow = onShowMovie.ToArray();
            ViewBag.OnComming = onCommingMovie.ToArray();

            return View(user);
        }


        public IActionResult MovieGrid(int? page)
        {
            var pagenumber = page ?? 1;
            ViewBag.ListMovies = _db.movies.ToList().ToPagedList(pagenumber,3);

            ViewData["Title"] = "MovieGrid";
            User user = Ultils.getCurrentUser(HttpContext);
            ViewBag.Movies = _db.movies.ToArray();
            ViewBag.Cate = _db.categories.ToArray();
            return View(user);
        }
        [Route("Home/MovieDetail/{id}")]
        public IActionResult MovieDetail(int? id)
        {
            ViewBag.Movie = _db.movies.Where(m => m.id == id).ToArray();
            User user = Ultils.getCurrentUser(HttpContext);
            var listTag = from ct in _db.categories
                          from mct in _db.movie_Categories
                          where ct.id == mct.category_id && mct.movie_id == id
                          select ct.name;

            var listCast = from ac in _db.actors
                           from mac in _db.movie_Actors
                           where ac.id == mac.actor_id && mac.movie_id == id
                           select ac;
            var listComment = from cm in _db.reviews
                              from us in _db.users
                              where cm.user_id == us.id
                              select new { cm.movie_id, cm.content, cm.create_date, us.displayname};


            ViewBag.listCast = listCast.ToArray();
            ViewBag.listTag = listTag.ToArray();
            ViewBag.listComment = (from cc in listComment
                                   where cc.movie_id == id
                                   select cc).ToArray();
            ViewData["movie_id"] = id;

            return View(user);
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
                           select new { sd.id, sd.start_time, r.branch_id, sd.room_id };



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
