using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;

namespace BoletoCinema.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReviewsAPIController : ControllerBase
    {
        private readonly BoletoContext _context;

        public ReviewsAPIController(BoletoContext context)
        {
            _context = context;
        }

        // GET: api/ReviewsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> Getreviews()
        {
            return await _context.reviews.ToListAsync();
        }

        // GET: api/ReviewsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            var review = await _context.reviews.FindAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        // PUT: api/ReviewsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview(int id, Review review)
        {
            if (id != review.id)
            {
                return BadRequest();
            }

            _context.Entry(review).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(id))
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

        // POST: api/ReviewsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            _context.reviews.Add(review);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReview", new { id = review.id }, review);
        }

        // DELETE: api/ReviewsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var review = await _context.reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            _context.reviews.Remove(review);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReviewExists(int id)
        {
            return _context.reviews.Any(e => e.id == id);
        }
    }
}
