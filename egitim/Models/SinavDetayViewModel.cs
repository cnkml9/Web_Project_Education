using EgitimWeb.Entites;
using System.Collections.Generic;

namespace egitim.Models
{
    public class SinavDetayViewModel
    {
        public string SinavAdi { get; set; }
        public int SinavId { get; set; }
        public List<TestDetay> TestDetaylar { get; set; }
        public int SoruID { get; set; }
        public Soru Soru { get; set; }
        public List<string> Cevap { get; set; }
    }
}
