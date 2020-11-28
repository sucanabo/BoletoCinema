using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using BoletoCinema.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
=======
using Microsoft.EntityFrameworkCore;
using BoletoCinema.Models;
>>>>>>> fff1d76f89b9c8a8b72a12c1870d2a29d4d4a4bd
namespace BoletoCinema.Areas.Admin.Data
{
    public class BoletoContext:DbContext
    {
        public BoletoContext(DbContextOptions<BoletoContext> options) : base(options) { }
        public DbSet<Actor> actors { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<ContactForm> contactForms { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Movie_Actor> movie_Actors { get; set; }
        public DbSet<Movie_Category> movie_Categories { get; set; }
<<<<<<< HEAD
        public DbSet<Movie_Discount> movie_Discounts { get; set; }
=======
        public DbSet<MovieDiscount> movieDiscounts { get; set; }
>>>>>>> fff1d76f89b9c8a8b72a12c1870d2a29d4d4a4bd
        public DbSet<Order> orders { get; set; }
        public DbSet<Report> reports { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Schedule> schedules { get; set; }
        public DbSet<Seat> seats { get; set; }
        public DbSet<Session> sessions { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserDiscount> userDiscounts { get; set; }
<<<<<<< HEAD
    }
}
    
=======

    }
    
}
>>>>>>> fff1d76f89b9c8a8b72a12c1870d2a29d4d4a4bd
