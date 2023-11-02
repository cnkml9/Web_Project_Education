using egitim.Data;
using egitim.Entity;
using EgitimWeb.Entites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace egitim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roller.Role_Admin + "," + Roller.Role_Depo_Admin)]
    public class SinavController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SinavController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult sinavEkle(string ad,string fiyat,int soruSayisi,IFormFile resimDosyasi)
        {
            Egitim egitim = new Egitim();
            try
            {
                if (resimDosyasi != null && resimDosyasi.Length > 0)
                {
                    string uzanti = Path.GetExtension(resimDosyasi.FileName);
                    string dosyaAd = Guid.NewGuid() + uzanti;
                    var resimYolu = Path.Combine(_webHostEnvironment.WebRootPath, "img", dosyaAd);

                    egitim.resimYolu = dosyaAd;

                    using (var fileStream = new FileStream(resimYolu, FileMode.Create))
                    {
                        resimDosyasi.CopyTo(fileStream);
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Resim kaydedilirken bir hata oluştu: " + ex.Message });
            }
            egitim.Ad = ad;
            egitim.soruSayisi = soruSayisi;
            egitim.fiyat = (float)Convert.ToDouble(fiyat);
            _context.egitims.Add(egitim);
            _context.SaveChanges();
            return Json("ok");
        }
        [HttpPost]
        public IActionResult dersKaydet(int sinavId,string dersAd)
        {
            Ders ders = new Ders();
            ders.Ad = dersAd;
            ders.EgitimId = sinavId;
            _context.Add(ders);
            _context.SaveChanges();
            return Json("ok");
        }
        [HttpPost]
        public IActionResult konuKaydet(int dersId, string konuAd)
        {
            Konu konu = new Konu();
            konu.Ad = konuAd;
            konu.DersId = dersId;
            _context.Add(konu);
            _context.SaveChanges();
            return Json("ok");
        }
        [HttpPost]
        public IActionResult soruKaydet(int konuId, string soru,string cevapA,string cevapB,string cevapC,string cevapD,string cevapE,string dogruCevap,string cozum)
        {
            Soru soru1 = new Soru();
            soru1.KonuId = konuId;
            soru1.SoruMetni = soru;
            soru1.BirinciSecenek = cevapA;
            soru1.IkıncıSecenek = cevapB;
            soru1.UcuncuSecenek = cevapC;
            soru1.DorduncuSecenek = cevapD;
            soru1.BesinciSecenek = cevapE;
            soru1.DogruCevap = dogruCevap;
            soru1.cozum = cozum;
            _context.Add(soru1);
            _context.SaveChanges();
            return Json("ok");
        }
        [HttpGet]
        public IActionResult getSinav()
        {
            return Json(_context.egitims.ToList());
        }
        [HttpGet]
        public IActionResult getDers(int egitimId)
        {
            return Json(_context.Dersler.Where(x => x.EgitimId == egitimId).ToList());
        }
        [HttpGet]
        public IActionResult getKonu(int dersId)
        {
            return Json(_context.Konular.Where(x => x.DersId == dersId).ToList());
        }
        [HttpGet]
        public IActionResult getSoruSayisi(int sinavId)
        {
            return Json(_context.egitims.Where(x => x.Id == sinavId).FirstOrDefault().soruSayisi);
        }
        [HttpGet]
        public IActionResult getSorular(int konuId)
        {
            return Json(_context.Sorus.Where(x => x.KonuId == konuId).ToList());
        }
        
    }
}
