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
    public class KonusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KonusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Konus
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Konular.Include(k => k.Ders);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Konus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var konu = await _context.Konular
                .Include(k => k.Ders)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (konu == null)
            {
                return NotFound();
            }

            return View(konu);
        }

        // GET: Admin/Konus/Create
        public IActionResult Create()
        {
            ViewData["DersId"] = new SelectList(_context.Dersler, "Id", "Ad");
            return View();
        }

        // POST: Admin/Konus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ad,DersId")] Konu konu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(konu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DersId"] = new SelectList(_context.Dersler, "Id", "Ad", konu.DersId);
            return View(konu);
        }

        // GET: Admin/Konus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var konu = await _context.Konular.FindAsync(id);
            if (konu == null)
            {
                return NotFound();
            }
            ViewData["DersId"] = new SelectList(_context.Dersler, "Id", "Ad", konu.DersId);
            return View(konu);
        }

        // POST: Admin/Konus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ad,DersId")] Konu konu)
        {
            if (id != konu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(konu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KonuExists(konu.Id))
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
            ViewData["DersId"] = new SelectList(_context.Dersler, "Id", "Ad", konu.DersId);
            return View(konu);
        }

        // GET: Admin/Konus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var konu = await _context.Konular
                .Include(k => k.Ders)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (konu == null)
            {
                return NotFound();
            }

            return View(konu);
        }

        // POST: Admin/Konus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var konu = await _context.Konular.FindAsync(id);
            _context.Konular.Remove(konu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KonuExists(int id)
        {
            return _context.Konular.Any(e => e.Id == id);
        }
    }
}
