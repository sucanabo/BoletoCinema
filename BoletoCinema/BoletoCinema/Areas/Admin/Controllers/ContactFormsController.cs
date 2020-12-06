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
    public class ContactFormsController : Controller
    {
        private readonly BoletoContext _context;

        public ContactFormsController(BoletoContext context)
        {
            _context = context;
        }

        // GET: Admin/ContactForms
        public async Task<IActionResult> Index()
        {
            var boletoContext = _context.contactForms.Include(c => c.user);
            return View(await boletoContext.ToListAsync());
        }

        // GET: Admin/ContactForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactForm = await _context.contactForms
                .Include(c => c.user)
                .FirstOrDefaultAsync(m => m.id == id);
            if (contactForm == null)
            {
                return NotFound();
            }

            return View(contactForm);
        }

        // GET: Admin/ContactForms/Create
        public IActionResult Create()
        {
            ViewData["user_id"] = new SelectList(_context.users, "id", "id");
            return View();
        }

        // POST: Admin/ContactForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,user_id,content,status,create_date")] ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["user_id"] = new SelectList(_context.users, "id", "id", contactForm.user_id);
            return View(contactForm);
        }

        // GET: Admin/ContactForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactForm = await _context.contactForms.FindAsync(id);
            if (contactForm == null)
            {
                return NotFound();
            }
            ViewData["user_id"] = new SelectList(_context.users, "id", "id", contactForm.user_id);
            return View(contactForm);
        }

        // POST: Admin/ContactForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,user_id,content,status,create_date")] ContactForm contactForm)
        {
            if (id != contactForm.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactFormExists(contactForm.id))
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
            ViewData["user_id"] = new SelectList(_context.users, "id", "id", contactForm.user_id);
            return View(contactForm);
        }

        // GET: Admin/ContactForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactForm = await _context.contactForms
                .Include(c => c.user)
                .FirstOrDefaultAsync(m => m.id == id);
            if (contactForm == null)
            {
                return NotFound();
            }

            return View(contactForm);
        }

        // POST: Admin/ContactForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactForm = await _context.contactForms.FindAsync(id);
            _context.contactForms.Remove(contactForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactFormExists(int id)
        {
            return _context.contactForms.Any(e => e.id == id);
        }
    }
}
