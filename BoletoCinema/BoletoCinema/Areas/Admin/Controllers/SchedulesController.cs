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
    public class SchedulesController : Controller
    {
        private readonly BoletoContext _context;

        public SchedulesController(BoletoContext context)
        {
            _context = context;
        }

        // GET: Admin/Schedules
        public async Task<IActionResult> Index()
        {
            var boletoContext = _context.schedules.Include(s => s.movie).Include(s => s.room);
            return View(await boletoContext.ToListAsync());
        }

        // GET: Admin/Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.schedules
                .Include(s => s.movie)
                .Include(s => s.room)
                .FirstOrDefaultAsync(m => m.id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Admin/Schedules/Create
        public IActionResult Create()
        {
            ViewData["movie_id"] = new SelectList(_context.movies, "id", "name");
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "name");
            return View();
        }

        // POST: Admin/Schedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,room_id,movie_id,start_time")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["movie_id"] = new SelectList(_context.movies, "id", "name", schedule.movie_id);
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "name", schedule.room_id);
            return View(schedule);
        }

        // GET: Admin/Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["movie_id"] = new SelectList(_context.movies, "id", "name", schedule.movie_id);
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "name", schedule.room_id);
            return View(schedule);
        }

        // POST: Admin/Schedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,room_id,movie_id,start_time")] Schedule schedule)
        {
            if (id != schedule.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.id))
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
            ViewData["movie_id"] = new SelectList(_context.movies, "id", "name", schedule.movie_id);
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "name", schedule.room_id);
            return View(schedule);
        }

        // GET: Admin/Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.schedules
                .Include(s => s.movie)
                .Include(s => s.room)
                .FirstOrDefaultAsync(m => m.id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Admin/Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.schedules.FindAsync(id);
            _context.schedules.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
            return _context.schedules.Any(e => e.id == id);
        }
    }
}
