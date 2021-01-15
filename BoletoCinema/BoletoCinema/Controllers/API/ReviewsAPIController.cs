using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;
using Newtonsoft.Json;

namespace BoletoCinema.Controllers.API
{
    [Route("user/api/[controller]/[action]")]
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
        public async Task<JsonResult> PostReview(Review review)
        {
            User user = Ultils.getCurrentUser(HttpContext);
            review.user_id = user.id;
            review.create_date = DateTime.Now;
            _context.reviews.Add(review);
            if (await _context.SaveChangesAsync() == 1)
            {
                return new JsonResult(new
                {
                    result = "success",
                    user_name = user.displayname,
                    content = review.content,
                    date = review.create_date.ToString("MM/dd/yyyy")
                }); ;
            }
            return new JsonResult(new
            {
                result = "fail",
                user_name = user.displayname,
                content = review.content,
                date = review.create_date.ToString("MM/dd/yyyy")
            }); ;


        }

        // DELETE: api/ReviewsAPI/5
        [HttpDelete("{id}")]
        public async Task<JsonResult> DeleteReview(int id)
        {
            var review = await _context.reviews.FindAsync(id);
            if (review == null)
            {
                return new JsonResult(new
                {
                    result = "fail"
                });
            }

            _context.reviews.Remove(review);
            await _context.SaveChangesAsync();

            return new JsonResult(new
            {
                result = "success",
                //review = review
            });
        }

        private bool ReviewExists(int id)
        {
            return _context.reviews.Any(e => e.id == id);
        }
    }
}
