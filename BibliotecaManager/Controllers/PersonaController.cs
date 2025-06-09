using BibliotecaManager.Models;
using System.Collections.Generic;

namespace BibliotecaManager.Controllers
{
    public class PersonaController
    {
        public List<Cliente> Clienti { get; set; } = new List<Cliente>();
        public List<Autore> Autori { get; set; } = new List<Autore>();

        public void AggingiAutore(Autore autore) => Autori.Add(autore);

        public void ModificaAutore(Autore autoreOriginale, Autore autoreModificato)
        {
            int index = Autori.IndexOf(autoreOriginale);
            if (index >= 0) Autori[index] = autoreModificato;
        }

        public void EliminaAutore(Autore autore) => Autori.Remove(autore);

        public void AggiungiCliente(Cliente cliente) => Clienti.Add(cliente);

        public void ModificaCliente(Cliente originale, Cliente modificato)
        {
            int index = Clienti.IndexOf(originale);
            if (index >= 0) Clienti[index] = modificato;
        }

        public void EliminaCliente(Cliente cliente) => Clienti.Remove(cliente);
    }
}
