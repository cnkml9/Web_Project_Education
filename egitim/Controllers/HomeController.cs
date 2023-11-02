using egitim.Data;
using egitim.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context; 


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var sinavlar = _context.egitims.ToList();
            return View(sinavlar);
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult Franchise()
        {
            return View();
        }

        public IActionResult insanKaynaklari()
        {
            return View();
        }

        public IActionResult iletisim()
        {
            return View();
        }

        public IActionResult sinavTakvimi()
        {
            return View();
        }

        public IActionResult KVKK()
        {
            return View();
        }

        public IActionResult Yayinlarimiz()
        {
            return View();
        }

        public IActionResult Duyuru()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
