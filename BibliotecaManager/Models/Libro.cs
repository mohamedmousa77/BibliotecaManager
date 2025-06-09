namespace BibliotecaManager.Models
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titolo { get; set; }
        public string CasaEditrice { get; set; }
        public int AnnoPubblicazione { get; set; }
        public string Genere { get; set; }
        public int QuantitaMagazzino { get; set; }
        public Autore Autore { get; set; }
    }

}
