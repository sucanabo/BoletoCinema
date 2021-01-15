using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace BoletoCinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActorsController : Controller
    {
        private readonly BoletoContext _context;

        public ActorsController(BoletoContext context)
        {
            _context = context;
        }

        // GET: Admin/Actors
        public async Task<IActionResult> Index()
        {
            return View(await _context.actors.ToListAsync());
        }

        // GET: Admin/Actors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.actors
                .FirstOrDefaultAsync(m => m.id == id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // GET: Admin/Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Actors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,image")] Actor actor, IFormFile ful)
        {
           
            if (ModelState.IsValid)
            {
                _context.Add(actor);
                await _context.SaveChangesAsync();
                string path = Path.Combine(
                   Directory.GetCurrentDirectory(), "wwwroot/Admin/assets/images/actor",
                   actor.id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]
                   );
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                actor.image = actor.id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(actor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        // GET: Admin/Actors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.actors.FindAsync(id);
            if (actor == null)
            {
                return NotFound();
            }
            return View(actor);
        }

        // POST: Admin/Actors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,image")] Actor actor, IFormFile ful)
        {
            if (id != actor.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ful != null)
                    {
                        var imagePath = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/Admin/assets/images/actor",
                            actor.image
                        );

                        System.IO.File.Delete(imagePath);

                        var newImagepath = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/Admin/assets/images/actor",
                            actor.id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]
                        );

                        using (var stream = new FileStream(newImagepath, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        actor.image = actor.id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    }
                    _context.Update(actor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActorExists(actor.id))
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
            return View(actor);
        }

        // GET: Admin/Actors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.actors
                .FirstOrDefaultAsync(m => m.id == id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // POST: Admin/Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await _context.actors.FindAsync(id);
            _context.actors.Remove(actor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActorExists(int id)
        {
            return _context.actors.Any(e => e.id == id);
        }
    }
}
