using System.Collections.Generic;

namespace EgitimWeb.Entites
{
    public class Konu
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
        public List<Soru> Sorular{ get; set; }
    }
}
