namespace BibliotecaManager.Models
{
    public class Autore
    {
        public Persona Persona { get; set; }
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string CasaEditrice { get; set; }

        public int IndiceDiGradimento { get; set; }
    }

}
