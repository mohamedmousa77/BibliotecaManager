using BibliotecaManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaManager.Controllers
{
    public class PrestitoController
    {
        public List<Prestito> Prestiti { get; set; } = new List<Prestito>();
        public bool AggiungiPrestito(Prestito prestito)
        {
            if (prestito.LibroPrestato.QuantitaMagazzino == 0) return false;

            Prestito NuovoPrestito = new Prestito
            {
                Cliente = prestito.Cliente,
                LibroPrestato = prestito.LibroPrestato,
                DataPrestito = DateTime.Now,
                DataScadenza = DateTime.Now.AddDays(30),
                DataDiConsegna = null,
            };

            prestito.LibroPrestato.QuantitaMagazzino -= 1;
            Prestiti.Add(NuovoPrestito);
            return true;
        }

        public void RegistraDiConsegna(Prestito Prestito, DateTime dataDiConsegna)
        {
            if (Prestito.DataDiConsegna == null)
            {
                Prestito.DataDiConsegna = dataDiConsegna;
                Prestito.LibroPrestato.QuantitaMagazzino += 1;
            }
        }

        public int PrestitiInCorso() 
            => Prestiti.Count(Pre => Pre.DataDiConsegna == null);

        public List<Prestito> PrestitiScaduti ()
            => Prestiti.Where(pre => pre.DataDiConsegna == null && pre.DataScadenza < DateTime.Now).ToList();
        
        public double PercentualePrestitiSoci()
        {
            int totale = Prestiti.Count;
            if (totale == 0) return 0.0;

            int soci = Prestiti.Count(p => p.Cliente.Socio);
            return (double)soci/ totale * 100.0;
        }
    }
}