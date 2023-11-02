using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using egitim.Data;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using egitim.Entity;
using System.Linq;

namespace EgitimWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Kullanici> _UserManager;

        public HomeController(ApplicationDbContext context,UserManager<Kullanici> userManager)
        {
            _context = context;
            _UserManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var kullaniciListesi = await _context.Kullanicilar.ToListAsync();
            foreach (var kullanici in kullaniciListesi)
            {
                var userRoles = await _UserManager.GetRolesAsync(kullanici);
                    kullanici.Role = userRoles.FirstOrDefault().ToString();
            }
            return View(kullaniciListesi);
        }

        public async Task<IActionResult> AktifPasifToggle(string id)
        {
            var kullanici = await _context.Kullanicilar.FindAsync(id);
            if (kullanici == null)
            {
                return NotFound();
            }

            kullanici.Aktif = !kullanici.Aktif;
            kullanici.KayitGuncelleme = DateTime.Now;

            _context.Update(kullanici);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
