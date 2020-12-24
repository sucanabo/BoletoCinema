using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;

namespace BoletoCinema.Areas.Admin.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movie_DiscountController : ControllerBase
    {
        private readonly BoletoContext _context;

        public Movie_DiscountController(BoletoContext context)
        {
            _context = context;
        }

        // GET: api/Movie_Discount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie_Discount>>> Getmovie_Discounts()
        {
            return await _context.movie_Discounts.ToListAsync();
        }

        // GET: api/Movie_Discount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie_Discount>> GetMovie_Discount(int id)
        {
            var movie_Discount = await _context.movie_Discounts.FindAsync(id);

            if (movie_Discount == null)
            {
                return NotFound();
            }

            return movie_Discount;
        }

        // PUT: api/Movie_Discount/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie_Discount(int id, Movie_Discount movie_Discount)
        {
            if (id != movie_Discount.id)
            {
                return BadRequest();
            }

            _context.Entry(movie_Discount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movie_DiscountExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movie_Discount
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie_Discount>> PostMovie_Discount(Movie_Discount movie_Discount)
        {
            _context.movie_Discounts.Add(movie_Discount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie_Discount", new { id = movie_Discount.id }, movie_Discount);
        }

        // DELETE: api/Movie_Discount/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie_Discount(int id)
        {
            var movie_Discount = await _context.movie_Discounts.FindAsync(id);
            if (movie_Discount == null)
            {
                return NotFound();
            }

            _context.movie_Discounts.Remove(movie_Discount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Movie_DiscountExists(int id)
        {
            return _context.movie_Discounts.Any(e => e.id == id);
        }
    }
}
