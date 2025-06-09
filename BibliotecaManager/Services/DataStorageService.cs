using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using BibliotecaManager.Models;

namespace BibliotecaManager.Services
{
    public class DataStorageService
    {
        private const string AutoriFile = "Autori.json";
        private const string ClientiFile = "Clienti.json";
        private const string LibriFile = "Libri.json";
        private const string PrestitiFile = "Prestiti.json";

        public void SalvaTutti
         ( string folderPath, List<Autore> autori, List<Cliente> clienti, List<Libro> libri, List<Prestito> prestiti )
        {
            try
            {
                File.WriteAllText(Path.Combine(folderPath, AutoriFile), JsonConvert.SerializeObject(autori, Formatting.Indented));
                File.WriteAllText(Path.Combine(folderPath, ClientiFile), JsonConvert.SerializeObject(clienti, Formatting.Indented));
                File.WriteAllText(Path.Combine(folderPath, LibriFile), JsonConvert.SerializeObject(libri, Formatting.Indented));
                File.WriteAllText(Path.Combine(folderPath, PrestitiFile), JsonConvert.SerializeObject(prestiti, Formatting.Indented));
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il salvataggio: " + ex.Message);
            }
        }
        public (List<Autore>, List<Cliente>, List<Libro>, List<Prestito>) CaricaTutti(string folderPath)
        {
            try
            {
                var autori = LeggiFile<Autore>(Path.Combine(folderPath, AutoriFile));
                var clienti = LeggiFile<Cliente>(Path.Combine(folderPath, ClientiFile));
                var libri = LeggiFile<Libro>(Path.Combine(folderPath, LibriFile));
                var prestiti = LeggiFile<Prestito>(Path.Combine(folderPath, PrestitiFile));

                return (autori, clienti, libri, prestiti);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento: " + ex.Message);
            }
        }

        // Metodo generico per leggere un file JSON
        private List<T> LeggiFile<T>(string path)
        {
            if (!File.Exists(path)) return new List<T>();
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }

    }
}
