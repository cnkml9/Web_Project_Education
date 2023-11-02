using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EgitimWeb.Entites;
using egitim.Data;

namespace egitim.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Ders
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Dersler.Include(d => d.Egtim);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Ders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ders = await _context.Dersler
                .Include(d => d.Egtim)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ders == null)
            {
                return NotFound();
            }

            return View(ders);
        }

        // GET: Admin/Ders/Create
        public IActionResult Create()
        {
            ViewData["EgitimId"] = new SelectList(_context.egitims, "Id", "Ad");
            return View();
        }

        // POST: Admin/Ders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ad,EgitimId")] Ders ders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EgitimId"] = new SelectList(_context.egitims, "Id", "Ad", ders.EgitimId);
            return View(ders);
        }

        // GET: Admin/Ders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ders = await _context.Dersler.FindAsync(id);
            if (ders == null)
            {
                return NotFound();
            }
            ViewData["EgitimId"] = new SelectList(_context.egitims, "Id", "Ad", ders.EgitimId);
            return View(ders);
        }

        // POST: Admin/Ders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ad,EgitimId")] Ders ders)
        {
            if (id != ders.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DersExists(ders.Id))
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
            ViewData["EgitimId"] = new SelectList(_context.egitims, "Id", "Ad", ders.EgitimId);
            return View(ders);
        }

        // GET: Admin/Ders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ders = await _context.Dersler
                .Include(d => d.Egtim)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ders == null)
            {
                return NotFound();
            }

            return View(ders);
        }

        // POST: Admin/Ders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ders = await _context.Dersler.FindAsync(id);
            _context.Dersler.Remove(ders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DersExists(int id)
        {
            return _context.Dersler.Any(e => e.Id == id);
        }
    }
}
