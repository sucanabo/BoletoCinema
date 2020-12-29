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
    public class Movie_ActorController : ControllerBase
    {
        private readonly BoletoContext _context;

        public Movie_ActorController(BoletoContext context)
        {
            _context = context;
        }

        // GET: api/Movie_Actor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie_Actor>>> Getmovie_Actors()
        {
            return await _context.movie_Actors.ToListAsync();
        }

        // GET: api/Movie_Actor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie_Actor>> GetMovie_Actor(int id)
        {
            var movie_Actor = await _context.movie_Actors.FindAsync(id);

            if (movie_Actor == null)
            {
                return NotFound();
            }

            return movie_Actor;
        }

        // PUT: api/Movie_Actor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie_Actor(int id, Movie_Actor movie_Actor)
        {
            if (id != movie_Actor.id)
            {
                return BadRequest();
            }

            _context.Entry(movie_Actor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movie_ActorExists(id))
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

        // POST: api/Movie_Actor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie_Actor>> PostMovie_Actor(Movie_Actor movie_Actor)
        {
            _context.movie_Actors.Add(movie_Actor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie_Actor", new { id = movie_Actor.id }, movie_Actor);
        }

        // DELETE: api/Movie_Actor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie_Actor(int id)
        {
            var movie_Actor = await _context.movie_Actors.FindAsync(id);
            if (movie_Actor == null)
            {
                return NotFound();
            }

            _context.movie_Actors.Remove(movie_Actor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Movie_ActorExists(int id)
        {
            return _context.movie_Actors.Any(e => e.id == id);
        }
    }
}
