using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;

namespace BoletoCinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SeatsController : Controller
    {
        private readonly BoletoContext _context;

        public SeatsController(BoletoContext context)
        {
            _context = context;
        }

        // GET: Admin/Seats
        public async Task<IActionResult> Index()
        {
            var boletoContext = _context.seats.Include(s => s.room);
            return View(await boletoContext.ToListAsync());
        }

        // GET: Admin/Seats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat = await _context.seats
                .Include(s => s.room)
                .FirstOrDefaultAsync(m => m.id == id);
            if (seat == null)
            {
                return NotFound();
            }

            return View(seat);
        }

        // GET: Admin/Seats/Create
        public IActionResult Create()
        {
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "id");
            return View();
        }

        // POST: Admin/Seats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,room_id,position,status")] Seat seat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "id", seat.room_id);
            return View(seat);
        }

        // GET: Admin/Seats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat = await _context.seats.FindAsync(id);
            if (seat == null)
            {
                return NotFound();
            }
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "id", seat.room_id);
            return View(seat);
        }

        // POST: Admin/Seats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,room_id,position,status")] Seat seat)
        {
            if (id != seat.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeatExists(seat.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "id", seat.room_id);
            return View(seat);
        }

        // GET: Admin/Seats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat = await _context.seats
                .Include(s => s.room)
                .FirstOrDefaultAsync(m => m.id == id);
            if (seat == null)
            {
                return NotFound();
            }

            return View(seat);
        }

        // POST: Admin/Seats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seat = await _context.seats.FindAsync(id);
            _context.seats.Remove(seat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeatExists(int id)
        {
            return _context.seats.Any(e => e.id == id);
        }
    }
}
