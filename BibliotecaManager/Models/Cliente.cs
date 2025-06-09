

namespace BibliotecaManager.Models
{
    public class  Cliente 
    {
        public Persona Persona { get; set; }

        public string Mail { get; set; }
        public string Telefono { get; set; }    
        public bool Socio { get; set; }

    }
}
