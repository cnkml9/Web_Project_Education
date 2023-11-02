using egitim.Data;
using egitim.Entity;
using egitim.Models;
using EgitimWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace egitim.Areas.Ogrenci.Controllers
{
    [Area("Ogrenci")]

    public class GoruntulemeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Kullanici> _UserManager;

        public GoruntulemeController(ApplicationDbContext context, UserManager<Kullanici> userManager)
        {
            _context = context;
            _UserManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BitirilenSinavlar()
        {
            string kullaniciId = _UserManager.GetUserId(User);

            var bitirilenSinavlar = _context.Testler
                .Include(t => t.testDetays).ThenInclude(x => x.Konu)
                .Where(x => x.KullaniciId == kullaniciId && x.bitirdi == true)
                .OrderByDescending(x => x.Id)
                .ToList();

            var model = new List<SinavDetayViewModel>();

            foreach (var sinav in bitirilenSinavlar)
            {
                var sinavDetay = new SinavDetayViewModel
                {
                    SinavAdi = sinav.Ad,
                    SinavId = sinav.Id,
                    TestDetaylar = sinav.testDetays.ToList()
                };

                model.Add(sinavDetay);
            }

            return View(model);
        }
        public IActionResult SinavDetay(int sinavId)
        {
            var sinav = _context.Testler
                .Include(t => t.testDetays).ThenInclude(x => x.Konu)
                .FirstOrDefault(t => t.Id == sinavId);

            if (sinav == null)
            {
                return NotFound();
            }

            var model = new SinavDetayViewModel
            {
                SinavAdi = sinav.Ad,
                TestDetaylar = sinav.testDetays.ToList()
            };

            return PartialView("SinavDetay", model);
        }

        public IActionResult getSoru()
        {
            return View();
        }

        public IActionResult SoruCevap(int sinavId)
        {
            var soruCevap = _context.Testler
               .Include(t => t.testDetays).ThenInclude(x => x.Konu)
               .FirstOrDefault(t => t.Id == sinavId);

            var cevaplar = new List<string>(); // Uygun tüm cevapları depolamak için bir liste oluşturun



            if (soruCevap != null)
            {
                var konuIdListesi = soruCevap.testDetays.Select(td => td.Konu.Id).ToList();
                var cevaplar2 = _context.Sorus.Where(s => konuIdListesi.Contains(s.KonuId)).Select(s => s.cozum).ToList();

                var model = new SinavDetayViewModel
                {
                    Cevap = cevaplar2
                };

                return PartialView("SoruCevap", model);
            }

            return PartialView("SoruCevap", 2);

        }




    }
}
