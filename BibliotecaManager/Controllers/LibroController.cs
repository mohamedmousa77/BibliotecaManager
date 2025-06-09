using BibliotecaManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaManager.Controllers
{
    public class LibroController
    {
        public List<Libro> Libri { get; set; } = new List<Libro>();

        private readonly List<Prestito> prestiti;

        public LibroController(List<Prestito> prestiti)
        {
            this.prestiti = prestiti;
        }

        public void AggiungiLibro(Libro libro) => Libri.Add(libro);

        public void ModificaLibro(Libro LibroOriginale, Libro LibroModificato)
        {
            int index = Libri.IndexOf(LibroOriginale);

            if (index >= 0) Libri[index] = LibroModificato;
        }

        public bool EliminaLibro(Libro libro)
        {
            if (prestiti.Any(p => p.LibroPrestato == libro && p.DataDiConsegna == null)) return false;

            return Libri.Remove(libro);

        }
    }
}
