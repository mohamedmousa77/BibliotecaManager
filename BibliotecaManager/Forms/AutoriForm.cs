using BibliotecaManager.Controllers;
using BibliotecaManager.Models;
using BibliotecaManager.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class AutoriForm : Form
    {
        private PersonaController personaController;
        private DataStorageService storageService;
        private string folderPath;

        public AutoriForm(PersonaController controller, DataStorageService storage, string path)
        {
            InitializeComponent();
            personaController = controller;
            storageService = storage;
            folderPath = path;
            
            ConfiguraGrid();
            AggiornaGrid(); // Ora mostrerà i dati caricati dal file JSON
        }

        private void ConfiguraGrid()
        {
            dgvAutori.AutoGenerateColumns = false;
            dgvAutori.Columns.Clear();

            dgvAutori.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAutori.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cognome",
                DataPropertyName = "Cognome",
                HeaderText = "Cognome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAutori.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CasaEditrice",
                DataPropertyName = "CasaEditrice",
                HeaderText = "Casa Editrice",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAutori.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IndiceDiGradimento",
                DataPropertyName = "IndiceDiGradimento",
                HeaderText = "Gradimento",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void AggiornaGrid()
        {
            try
            {
                dgvAutori.SuspendLayout();
                var dati = personaController.Autori.Select(a => new
                {
                    Nome = a.Persona.Nome,
                    Cognome = a.Persona.Cognome,
                    CasaEditrice = a.CasaEditrice,
                    IndiceDiGradimento = a.IndiceDiGradimento
                }).ToList();

                dgvAutori.DataSource = null;
                dgvAutori.DataSource = dati;
            }
            finally
            {
                dgvAutori.ResumeLayout();
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            using (var form = new InserisciAutoreForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        personaController.AggingiAutore(form.Autore);
                        AggiornaGrid();
                        storageService.SalvaTutti(folderPath, personaController.Autori, new List<Cliente>(), new List<Libro>(), new List<Prestito>());
                        
                        if (storageService.VerificaSalvataggio(folderPath))
                        {
                            MessageBox.Show($"Dati salvati correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Errore nella verifica del salvataggio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvAutori.CurrentRow?.DataBoundItem != null)
            {
                var autoreSelezionato = personaController.Autori
                    .FirstOrDefault(a => a.Persona.Nome == dgvAutori.CurrentRow.Cells["Nome"].Value.ToString() &&
                                       a.Persona.Cognome == dgvAutori.CurrentRow.Cells["Cognome"].Value.ToString());

                if (autoreSelezionato != null)
                {
                    using (var form = new ModificaAutoreForm(autoreSelezionato))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                storageService.SalvaTutti(folderPath, personaController.Autori, new List<Cliente>(), new List<Libro>(), new List<Prestito>());
                                AggiornaGrid();
                                
                                if (storageService.VerificaSalvataggio(folderPath))
                                {
                                    MessageBox.Show("Modifiche salvate correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvAutori.CurrentRow?.DataBoundItem != null)
            {
                var autoreSelezionato = personaController.Autori
                    .FirstOrDefault(a => a.Persona.Nome == dgvAutori.CurrentRow.Cells["Nome"].Value.ToString() &&
                                       a.Persona.Cognome == dgvAutori.CurrentRow.Cells["Cognome"].Value.ToString());

                if (autoreSelezionato != null)
                {
                    if (MessageBox.Show("Sei sicuro di voler eliminare questo autore?", "Conferma eliminazione",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        personaController.EliminaAutore(autoreSelezionato);
                        AggiornaGrid();
                        storageService.SalvaTutti(folderPath, personaController.Autori, new List<Cliente>(), new List<Libro>(), new List<Prestito>());

                    }
                }
            }
        }

        private void AutoriForm_Load(object sender, EventArgs e)
        {

        }
    }
}
