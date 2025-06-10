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

        public void SalvaTutti(string folderPath, List<Autore> autori, List<Cliente> clienti, List<Libro> libri, List<Prestito> prestiti)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                File.WriteAllText(Path.Combine(folderPath, AutoriFile), JsonConvert.SerializeObject(autori, Formatting.Indented));
                File.WriteAllText(Path.Combine(folderPath, ClientiFile), JsonConvert.SerializeObject(clienti, Formatting.Indented));
                File.WriteAllText(Path.Combine(folderPath, LibriFile), JsonConvert.SerializeObject(libri, Formatting.Indented));
                File.WriteAllText(Path.Combine(folderPath, PrestitiFile), JsonConvert.SerializeObject(prestiti, Formatting.Indented));
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il salvataggio in {folderPath}: {ex.Message}");
            }
        }

        public (List<Autore>, List<Cliente>, List<Libro>, List<Prestito>) CaricaTutti(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var autori = LeggiFile<Autore>(Path.Combine(folderPath, AutoriFile));
                var clienti = LeggiFile<Cliente>(Path.Combine(folderPath, ClientiFile));
                var libri = LeggiFile<Libro>(Path.Combine(folderPath, LibriFile));
                var prestiti = LeggiFile<Prestito>(Path.Combine(folderPath, PrestitiFile));

                return (autori, clienti, libri, prestiti);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento dei dati: {ex.Message}");
            }
        }

        private List<T> LeggiFile<T>(string path)
        {
            if (!File.Exists(path))
            {
                return new List<T>();
            }

            try
            {
                var json = File.ReadAllText(path);
                var result = JsonConvert.DeserializeObject<List<T>>(json);
                return result ?? new List<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante la lettura del file {Path.GetFileName(path)}: {ex.Message}");
            }
        }

        public bool VerificaSalvataggio(string folderPath)
        {
            try
            {
                var files = new[] { AutoriFile, ClientiFile, LibriFile, PrestitiFile };
                foreach (var file in files)
                {
                    var path = Path.Combine(folderPath, file);
                    if (!File.Exists(path))
                    {
                        return false;
                    }
                    // Prova a leggere il file per verificare che sia un JSON valido
                    var content = File.ReadAllText(path);
                    JsonConvert.DeserializeObject(content);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
