using egitim.Entity;
using System.Collections.Generic;

namespace EgitimWeb.Entites
{
    public class Test
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int dogruCevap { get; set; }
        public int YanlisCevap { get; set; }
        public int BosCevap { get; set; }
        public bool bitirdi{ get; set; }
        public string KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public List<TestDetay> testDetays { get; set; }
    }
    public class TestDetay
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public int KonuId { get; set; }
        public Konu Konu { get; set; }
        public int SoruSayisi { get; set; }
        public int dogruCevap { get; set; }
        public int YanlisCevap { get; set; }
        public int BosCevap { get; set; }

    }
}
