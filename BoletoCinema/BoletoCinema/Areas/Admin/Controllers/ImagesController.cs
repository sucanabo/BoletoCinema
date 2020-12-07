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
    public class ImagesController : Controller
    {
        private readonly BoletoContext _context;

        public ImagesController(BoletoContext context)
        {
            _context = context;
        }

        // GET: Admin/Images
        public async Task<IActionResult> Index()
        {
            var boletoContext = _context.images.Include(i => i.movie);
            return View(await boletoContext.ToListAsync());
        }

        // GET: Admin/Images/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.images
                .Include(i => i.movie)
                .FirstOrDefaultAsync(m => m.id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // GET: Admin/Images/Create
        public IActionResult Create()
        {
            ViewData["movie_id"] = new SelectList(_context.movies, "id", "id");
            return View();
        }

        // POST: Admin/Images/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,movie_id,path,status")] Image image)
        {
            if (ModelState.IsValid)
            {
                _context.Add(image);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["movie_id"] = new SelectList(_context.movies, "id", "id", image.movie_id);
            return View(image);
        }

        // GET: Admin/Images/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.images.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }
            ViewData["movie_id"] = new SelectList(_context.movies, "id", "id", image.movie_id);
            return View(image);
        }

        // POST: Admin/Images/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,movie_id,path,status")] Image image)
        {
            if (id != image.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(image);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageExists(image.id))
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
            ViewData["movie_id"] = new SelectList(_context.movies, "id", "id", image.movie_id);
            return View(image);
        }

        // GET: Admin/Images/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.images
                .Include(i => i.movie)
                .FirstOrDefaultAsync(m => m.id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // POST: Admin/Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var image = await _context.images.FindAsync(id);
            _context.images.Remove(image);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImageExists(int id)
        {
            return _context.images.Any(e => e.id == id);
        }
    }
}
