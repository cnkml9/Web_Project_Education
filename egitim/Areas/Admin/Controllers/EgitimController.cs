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
    public class EgitimController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EgitimController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Egitim
        public async Task<IActionResult> Index()
        {
            return View(await _context.egitims.ToListAsync());
        }

        // GET: Admin/Egitim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var egitim = await _context.egitims
                .FirstOrDefaultAsync(m => m.Id == id);
            if (egitim == null)
            {
                return NotFound();
            }

            return View(egitim);
        }

        // GET: Admin/Egitim/Create
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ad,fiyat,resimYolu,soruSayisi")] Egitim egitim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(egitim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(egitim);
        }

        // GET: Admin/Egitim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var egitim = await _context.egitims.FindAsync(id);
            if (egitim == null)
            {
                return NotFound();
            }
            return View(egitim);
        }

        // POST: Admin/Egitim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ad,fiyat,resimYolu,soruSayisi")] Egitim egitim)
        {
            if (id != egitim.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(egitim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EgitimExists(egitim.Id))
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
            return View(egitim);
        }

        // GET: Admin/Egitim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var egitim = await _context.egitims
                .FirstOrDefaultAsync(m => m.Id == id);
            if (egitim == null)
            {
                return NotFound();
            }

            return View(egitim);
        }

        // POST: Admin/Egitim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var egitim = await _context.egitims.FindAsync(id);
            _context.egitims.Remove(egitim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EgitimExists(int id)
        {
            return _context.egitims.Any(e => e.Id == id);
        }
    }
}
