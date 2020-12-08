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
    public class TicketsController : Controller
    {
        private readonly BoletoContext _context;

        public TicketsController(BoletoContext context)
        {
            _context = context;
        }

        // GET: Admin/Tickets
        public async Task<IActionResult> Index()
        {
            var boletoContext = _context.tickets.Include(t => t.order).Include(t => t.room).Include(t => t.schedule).Include(t => t.seat);
            return View(await boletoContext.ToListAsync());
        }

        // GET: Admin/Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.tickets
                .Include(t => t.order)
                .Include(t => t.room)
                .Include(t => t.schedule)
                .Include(t => t.seat)
                .FirstOrDefaultAsync(m => m.id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Admin/Tickets/Create
        public IActionResult Create()
        {
            ViewData["order_id"] = new SelectList(_context.orders, "id", "id");
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "id");
            ViewData["schedule_id"] = new SelectList(_context.schedules, "id", "id");
            ViewData["seat_id"] = new SelectList(_context.seats, "id", "id");
            return View();
        }

        // POST: Admin/Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,order_id,room_id,seat_id,schedule_id,price")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["order_id"] = new SelectList(_context.orders, "id", "id", ticket.order_id);
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "id", ticket.room_id);
            ViewData["schedule_id"] = new SelectList(_context.schedules, "id", "id", ticket.schedule_id);
            ViewData["seat_id"] = new SelectList(_context.seats, "id", "id", ticket.seat_id);
            return View(ticket);
        }

        // GET: Admin/Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            ViewData["order_id"] = new SelectList(_context.orders, "id", "id", ticket.order_id);
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "id", ticket.room_id);
            ViewData["schedule_id"] = new SelectList(_context.schedules, "id", "id", ticket.schedule_id);
            ViewData["seat_id"] = new SelectList(_context.seats, "id", "id", ticket.seat_id);
            return View(ticket);
        }

        // POST: Admin/Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,order_id,room_id,seat_id,schedule_id,price")] Ticket ticket)
        {
            if (id != ticket.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.id))
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
            ViewData["order_id"] = new SelectList(_context.orders, "id", "id", ticket.order_id);
            ViewData["room_id"] = new SelectList(_context.rooms, "id", "id", ticket.room_id);
            ViewData["schedule_id"] = new SelectList(_context.schedules, "id", "id", ticket.schedule_id);
            ViewData["seat_id"] = new SelectList(_context.seats, "id", "id", ticket.seat_id);
            return View(ticket);
        }

        // GET: Admin/Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.tickets
                .Include(t => t.order)
                .Include(t => t.room)
                .Include(t => t.schedule)
                .Include(t => t.seat)
                .FirstOrDefaultAsync(m => m.id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Admin/Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.tickets.FindAsync(id);
            _context.tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.tickets.Any(e => e.id == id);
        }
    }
}
