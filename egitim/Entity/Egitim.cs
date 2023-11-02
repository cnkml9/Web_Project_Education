using System.Collections.Generic;

namespace EgitimWeb.Entites
{
    public class Egitim
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public float fiyat { get; set; }
        public string  resimYolu { get; set; }
        public int soruSayisi { get; set; }
        public List<Ders> Dersler{ get; set; }
    }
}
