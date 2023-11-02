using egitim.Data;
using egitim.Entity;
using EgitimWeb.Entites;
using EgitimWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EgitimWeb.Areas.Ogrenci.Controllers
{
    [Area("Ogrenci")]
    public class HomeController : Controller
    {
        private readonly UserManager<Kullanici> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(UserManager<Kullanici> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pasif()
        {
            return View();
        }
        public IActionResult sinavOlustur()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Identity","Login", "Account"); // Kullanıcı giriş yapmamışsa giriş sayfasına yönlendir
            }
            return View();
        }
        public IActionResult getDetays(int testId)
        {
            var detaylar = _context.testDetaylar.Where(x => x.TestId == testId).Include(x => x.Konu).ToList();
            return PartialView("_DetaylarPartial",detaylar); 
        }
        [HttpGet]
        public IActionResult getSinav()
        {
            return Json(_context.egitims.ToList());
        }
        [HttpGet]
        public IActionResult addTest(string Ad)
        {
            Test test = new Test();
            test.Ad = Ad;
            string kullaniciId = _userManager.GetUserId(User);
            // Kullanıcıyı teste ilişkilendir
            test.KullaniciId = kullaniciId;
            _context.Add(test);
            _context.SaveChanges();
            return Json("Testleriniz Eklendi");
        }
        [HttpPost]
        public IActionResult addSoru(int testId,int konuId,int adet)
        {
            TestDetay testDetay = new TestDetay();
            testDetay.KonuId = konuId;
            testDetay.SoruSayisi = adet;
            testDetay.TestId = testId;
            _context.Add(testDetay);
            _context.SaveChanges();
            return Json("Testleriniz Eklendi");
        }
        [HttpGet]
        public IActionResult getTest()
        {
            string kullaniciId = _userManager.GetUserId(User);
            return Json(_context.Testler.Where(x => x.KullaniciId == kullaniciId && x.bitirdi ==  false).ToList());
        }
        [HttpGet]
        public IActionResult startExam()
        {
            return View();
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
        public IActionResult getsoruSayisi(int konuId)
        {
            return Json(_context.Sorus.Where(x => x.KonuId == konuId).ToList().Count);
        }
        [HttpPost]
        public IActionResult sinavSonuc(List<InputModelSoru> cevaplar,int testId)
        {

            int dogruCevap = 0;
            int bosCevap = 0;
            int yanlisCevap = 0;

            foreach (var item in cevaplar)
            {
                TestDetay testDetay = _context.testDetaylar.Where(x => x.Id == item.detayId).FirstOrDefault();
                var soru = _context.Sorus.Where(x => x.Id == item.soruId).FirstOrDefault();

                if (item.secilenCevap == soru.DogruCevap.ToString().ToUpper())
                {
                    dogruCevap++;
                    testDetay.dogruCevap++;
                }
                if (string.IsNullOrEmpty(item.secilenCevap))
                {
                    bosCevap++;
                    testDetay.BosCevap++;
                }
                if (!string.IsNullOrEmpty(item.secilenCevap) && item.secilenCevap != soru.DogruCevap.ToString().ToUpper())
                {
                    yanlisCevap++;
                    testDetay.YanlisCevap++;
                }
                

                _context.Update(testDetay);
                _context.SaveChanges();
            }

            Test test = _context.Testler.Where(x => x.Id == testId).FirstOrDefault();
            test.dogruCevap = dogruCevap;
            test.YanlisCevap = yanlisCevap;
            test.BosCevap = bosCevap;
            test.bitirdi = true;
            _context.Update(test);
            _context.SaveChanges();

            var sonucModel = new SonucModel
            {
                DogruCevap = dogruCevap,
                YanlisCevap = yanlisCevap,
                BosCevap = bosCevap
            };

            return Json(sonucModel);
        }

        [HttpGet]
        public IActionResult startExamPartial(int testId)
        {
            SorularViewModel sorularViewModel = new SorularViewModel();
            var test = _context.Testler.Where(x => x.Id == testId).Include(x => x.testDetays).FirstOrDefault();
            sorularViewModel.Test = test;
            sorularViewModel.Sorular = new List<SoruDetayli>();
            sorularViewModel.Cevap = new List<soruCevap>();
            foreach (var item in test.testDetays)
            {
                var sorular = _context.Sorus.Where(x => x.KonuId == item.KonuId).ToList();
                var randomSorular = sorular.OrderBy(x => Guid.NewGuid()).Take(item.SoruSayisi).ToList();

                foreach (var soru in randomSorular)
                {
                    var soruDetayli = new SoruDetayli
                    {
                        Id = soru.Id,
                        SoruMetni = soru.SoruMetni,
                        BirinciSecenek = soru.BirinciSecenek,
                        IkıncıSecenek = soru.IkıncıSecenek,
                        UcuncuSecenek = soru.UcuncuSecenek,
                        DorduncuSecenek = soru.DorduncuSecenek,
                        BesinciSecenek = soru.BesinciSecenek,
                        DogruCevap = soru.DogruCevap,
                        KonuId = soru.KonuId,
                        Konu = soru.Konu,
                        detayId = item.Id
                    };

                    var cevap = new soruCevap
                    {
                        Id = soru.Id,
                        DogruCevap = soru.DogruCevap,
                        cozum = soru.cozum
                    };
                    sorularViewModel.Cevap.Add(cevap);
                    sorularViewModel.Sorular.Add(soruDetayli);
                }
            }
            return PartialView("_ExamPartial",sorularViewModel);
        }

        public IActionResult GetCevap()
        {
            SorularViewModel sorularViewModel = new SorularViewModel();
            sorularViewModel.Cevap = new List<soruCevap>();


            return PartialView("_CevapPartial", sorularViewModel.Cevap);
        }

    }
    public class InputModelSoru {

        public int soruId { get; set; }
        public int detayId { get; set; }
        public string secilenCevap { get; set; }
        public string cevap { get; set; }
    }
    public class SonucModel
    {
        public int DogruCevap { get; set; }
        public int YanlisCevap { get; set; }
        public int BosCevap { get; set; }

    }
}
