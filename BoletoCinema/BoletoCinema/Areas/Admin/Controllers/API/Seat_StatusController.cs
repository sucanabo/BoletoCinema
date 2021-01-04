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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Seat_StatusController : ControllerBase
    {
        private readonly BoletoContext _context;

        public Seat_StatusController(BoletoContext context)
        {
            _context = context;
        }

        // GET: api/Seat_Status
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seat_Status>>> Getseat_status()
        {
            return await _context.seat_status.ToListAsync();
        }
        [HttpGet("{id}")]
        public IEnumerable<Seat_Status> GetSeat_StatusBySchedule(int id)
        {
            var allSeat_Status = from sch in _context.schedules
                                 from r in _context.rooms
                                 from s in _context.seats
                                 from st in _context.seat_status
                                 where sch.id == id && sch.room_id == r.id && r.id == s.room_id && s.id == st.seat_id
                                 select st;

            return allSeat_Status;
        }
        // GET: api/Seat_Status/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seat_Status>> GetSeat_Status(int id)
        {
            var seat_Status = await _context.seat_status.FindAsync(id);

            if (seat_Status == null)
            {
                return NotFound();
            }

            return seat_Status;
        }

        // PUT: api/Seat_Status/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeat_Status(int id, Seat_Status seat_Status)
        {
            if (id != seat_Status.id)
            {
                return BadRequest();
            }

            _context.Entry(seat_Status).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Seat_StatusExists(id))
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

        // POST: api/Seat_Status
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Seat_Status>> PostSeat_Status(Seat_Status seat_Status)
        {
            _context.seat_status.Add(seat_Status);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeat_Status", new { id = seat_Status.id }, seat_Status);
        }

        // DELETE: api/Seat_Status/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeat_Status(int id)
        {
            var seat_Status = await _context.seat_status.FindAsync(id);
            if (seat_Status == null)
            {
                return NotFound();
            }

            _context.seat_status.Remove(seat_Status);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Seat_StatusExists(int id)
        {
            return _context.seat_status.Any(e => e.id == id);
        }
    }
}
