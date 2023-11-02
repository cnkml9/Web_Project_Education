using egitim.Data;
using egitim.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace egitim.Areas.Ogrenci.ViewComponents
{
    public class GetAnswerViewComponent :ViewComponent
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<Kullanici> _UserManager;

        public GetAnswerViewComponent(ApplicationDbContext context, UserManager<Kullanici> userManager)
        {
            _context = context;
            _UserManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var soruCevap = _context.Sorus.Where(s => s.KonuId == 24).FirstOrDefault();
           
                var setCevap = soruCevap.cozum;
                return View(setCevap);
            
           
        }
    }
}
