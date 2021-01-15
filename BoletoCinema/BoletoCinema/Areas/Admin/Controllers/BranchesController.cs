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
    public class BranchesController : Controller
    {
        
        private readonly BoletoContext _context;

        public BranchesController(BoletoContext context)
        {
            _context = context;
        }

        // GET: Admin/Branches
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.branches.ToListAsync());
        }

        // GET: Admin/Branches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.branches
                .FirstOrDefaultAsync(m => m.id == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // GET: Admin/Branches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Branches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,address,status")] Branch branch)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(branch);
                await _context.SaveChangesAsync();
                SetAlert("Created success !");
                return RedirectToAction(nameof(Index));

            }
            SetAlert("Created fail !");
            return View(branch);
        }

        // GET: Admin/Branches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.branches.FindAsync(id);
            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);
        }

        // POST: Admin/Branches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,address,status")] Branch branch)
        {
            if (id != branch.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    SetAlert("Edited success !");
                    _context.Update(branch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    SetAlert("Edited fail !");
                    if (!BranchExists(branch.id))
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
            return View(branch);
        }

        // GET: Admin/Branches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.branches
                .FirstOrDefaultAsync(m => m.id == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // POST: Admin/Branches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            SetAlert("Deleted success !");
            var branch = await _context.branches.FindAsync(id);
            _context.branches.Remove(branch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchExists(int id)
        {
            return _context.branches.Any(e => e.id == id);
        }

        public void SetAlert(String mess)
        {
            TempData["StatusMessage"] = mess;
        }
    }
}
