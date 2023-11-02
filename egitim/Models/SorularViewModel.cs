using EgitimWeb.Entites;
using System.Collections.Generic;

namespace EgitimWeb.Models
{
    public class SorularViewModel
    {
        public Test Test{ get; set; }
        public List<SoruDetayli> Sorular{ get; set; }
        public List<soruCevap> Cevap { get; set; }

    }
    public class SoruDetayli
    {
        public int Id { get; set; }
        public string SoruMetni { get; set; }
        public string BirinciSecenek { get; set; }
        public string IkıncıSecenek { get; set; }
        public string UcuncuSecenek { get; set; }
        public string DorduncuSecenek { get; set; }
        public string? BesinciSecenek { get; set; }
        public string DogruCevap { get; set; }
        public string cozum { get; set; }
        public int KonuId { get; set; }
        public Konu Konu { get; set; }
        public int SoruID { get; set; }
        public Soru Soru { get; set; }
        public int detayId { get; set; }
    }

    public class soruCevap
    {
        public int Id { get; set; }
        public string SoruMetni { get; set; }
        public string DogruCevap { get; set; }
        public string cozum { get; set; }

    }
}
