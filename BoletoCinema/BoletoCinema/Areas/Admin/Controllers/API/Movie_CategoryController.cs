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
    public class Movie_CategoryController : ControllerBase
    {
        private readonly BoletoContext _context;

        public Movie_CategoryController(BoletoContext context)
        {
            _context = context;
        }

        // GET: api/Movie_Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie_Category>>> Getmovie_Categories()
        {
            return await _context.movie_Categories.ToListAsync();
        }

        // GET: api/Movie_Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie_Category>> GetMovie_Category(int id)
        {
            var movie_Category = await _context.movie_Categories.FindAsync(id);

            if (movie_Category == null)
            {
                return NotFound();
            }

            return movie_Category;
        }

        // PUT: api/Movie_Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie_Category(int id, Movie_Category movie_Category)
        {
            if (id != movie_Category.id)
            {
                return BadRequest();
            }

            _context.Entry(movie_Category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movie_CategoryExists(id))
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

        // POST: api/Movie_Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie_Category>> PostMovie_Category(Movie_Category movie_Category)
        {
            _context.movie_Categories.Add(movie_Category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie_Category", new { id = movie_Category.id }, movie_Category);
        }

        // DELETE: api/Movie_Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie_Category(int id)
        {
            var movie_Category = await _context.movie_Categories.FindAsync(id);
            if (movie_Category == null)
            {
                return NotFound();
            }

            _context.movie_Categories.Remove(movie_Category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Movie_CategoryExists(int id)
        {
            return _context.movie_Categories.Any(e => e.id == id);
        }
    }
}
