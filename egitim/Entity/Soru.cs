namespace EgitimWeb.Entites
{
    public class Soru
    {
        public int Id { get; set; }
        public string SoruMetni { get; set; }
        public string BirinciSecenek { get; set; }
        public string IkıncıSecenek { get; set; }
        public string UcuncuSecenek { get; set; }
        public string DorduncuSecenek { get; set; }
        public string? BesinciSecenek { get; set; }
        public string DogruCevap { get; set; }
        public string? cozum { get; set; }
        public int KonuId { get; set; }
        public Konu Konu { get; set; }

    }
}
