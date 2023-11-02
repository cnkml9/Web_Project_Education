namespace EgitimWeb.Entites
{

    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int EgitimId { get; set; }
        public Egitim Egtim { get; set; }
    }
}
