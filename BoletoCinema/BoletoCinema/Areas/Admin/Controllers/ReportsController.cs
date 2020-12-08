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
    public class ReportsController : Controller
    {
        private readonly BoletoContext _context;

        public ReportsController(BoletoContext context)
        {
            _context = context;
        }

        // GET: Admin/Reports
        public async Task<IActionResult> Index()
        {
            var boletoContext = _context.reports.Include(r => r.review);
            return View(await boletoContext.ToListAsync());
        }

        // GET: Admin/Reports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.reports
                .Include(r => r.review)
                .FirstOrDefaultAsync(m => m.id == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // GET: Admin/Reports/Create
        public IActionResult Create()
        {
            ViewData["review_id"] = new SelectList(_context.reviews, "id", "id");
            return View();
        }

        // POST: Admin/Reports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,reason,content,review_id,create_date,status")] Report report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(report);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["review_id"] = new SelectList(_context.reviews, "id", "id", report.review_id);
            return View(report);
        }

        // GET: Admin/Reports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.reports.FindAsync(id);
            if (report == null)
            {
                return NotFound();
            }
            ViewData["review_id"] = new SelectList(_context.reviews, "id", "id", report.review_id);
            return View(report);
        }

        // POST: Admin/Reports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,reason,content,review_id,create_date,status")] Report report)
        {
            if (id != report.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(report);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportExists(report.id))
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
            ViewData["review_id"] = new SelectList(_context.reviews, "id", "id", report.review_id);
            return View(report);
        }

        // GET: Admin/Reports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.reports
                .Include(r => r.review)
                .FirstOrDefaultAsync(m => m.id == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // POST: Admin/Reports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var report = await _context.reports.FindAsync(id);
            _context.reports.Remove(report);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportExists(int id)
        {
            return _context.reports.Any(e => e.id == id);
        }
    }
}
